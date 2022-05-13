using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using POS.Aux;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ImageList;

namespace POS
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {

        private void Inicializa()
        {
            Button acceptButon = new Button();
            this.AcceptButton = acceptButon;
            acceptButon.Click += new EventHandler(NewProductScanned);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UPCTx.Focus();
            CustomDrawRowIndicator(SalesGrid, MainView);
            if (!ValidarLicencia())
            {
                /*licencia invalida*/
                this.Close();
            }
            VigLb.Caption += CurrentLicence.Vigencia.ToString("dd-MM-yyyy");
            int intento = 1;
            DialogResult dr;
            Logon l = new Logon();
        OtroIntento: dr = l.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (l.Nombre == "")
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Cuenta errornea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (intento >= 3)
                        this.Close();
                    intento++;
                    goto OtroIntento;
                }
                else
                {
                    UserRLabel.Caption = "Bienvenido: " + l.Nombre;
                    User = l.User;
                }
            }
            else
            {
                MessageBox.Show("Debe registrarse para ingresar");
                this.Close();
            }
            l.Dispose();
            DownLoadData();
            GetLastSync();
        }

        private void GetLastSync()
        {
            string cmd = "SELECT LastSync FROM config";
            var row = LocalConnection.GetFirstRow(cmd);
            LSynctLb.Caption += row["LastSync"].ToString();
        }

        private bool ValidarLicencia()
        {
            bool isValid = false;
            var config = new Config();
            var getLicence = new GetLicence(config.DATABASE_PATH);
            if (File.Exists(config.DATABASE_PATH))
            {
                CurrentLicence = getLicence.ObtenerLicencia();
            }
            else
            {
                /*la base de datos no existe localmente*/
                getLicence.ShowDialog();
                CurrentLicence = getLicence.remoteLicence;
                if (!string.IsNullOrEmpty(CurrentLicence.ID))
                {
                    /*la licencia es valida*/
                    /*creo la base de datos local*/
                    File.WriteAllBytes(config.DATABASE_PATH, Properties.Resources.nanoPOS);
                    /*insero la licencia en la base de datos*/
                    var lite = new SQLiteAux(new Config().DATABASE_PATH);
                    string cmd = $"INSERT INTO licencias (ID,Nombre,Vigencia) VALUES ('{CurrentLicence.ID}','{CurrentLicence.Nombre}','{CurrentLicence.Vigencia.ToString("yyyy-MM-dd HH:mm")}')";
                    lite.ExecuteScalar(cmd);
                }
                else
                {
                    /*do nothing*/
                }
            }

            /*hay una licencia valida*/
            if (string.IsNullOrEmpty(CurrentLicence.ID))
            {
                /*licencia inexistente*/
                isValid = false;
                MessageBox.Show("Licencia invalida, contacte al proveedor");

            }
            else if (CurrentLicence.Vigencia > DateTime.Today)
            {
                /*licencia valida*/
                isValid = true;
            }
            else
            {
                /*licencia vencida*/
                MessageBox.Show("La licencia se encuentra vencida, contacta al distribuidor");
                isValid = false;
            }
            return isValid;
        }

        public static void CustomDrawRowIndicator(GridControl gridControl, GridView gridView)
        {
            gridView.IndicatorWidth = 50;
            // Handle this event to paint RowIndicator manually
            gridView.CustomDrawRowIndicator += (s, e) => {
                if (!e.Info.IsRowIndicator) return;
                GridView view = s as GridView;
                e.Handled = true;

                //e.Appearance.BackColor = view.FocusedRowHandle == e.RowHandle ? Color.Chocolate : Color.MediumSpringGreen;
                e.Appearance.FillRectangle(e.Cache, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Y - 4));
                if (e.Info.ImageIndex < 0) return;
                ImageCollection ic = e.Info.ImageCollection as ImageCollection;
                Image indicator = new Bitmap(Properties.Resources.delete);
                e.Cache.DrawImage(indicator, new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, indicator.Width, indicator.Height));
            };
        }
    }
}
