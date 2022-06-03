using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using POS.Aux;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int CONFIG_ROW_INDEX = 1;
        int CONFIG_TECLADO_INDEX = 0;
        int CONFIG_SEARCH_INDEX = 1;
        int CONFIG_PAGO_COLUMN_INDEX = 2;
        private void Inicializa()
        {
            Button acceptButon = new Button();
            this.AcceptButton = acceptButon;
            VENTA_DETALLE_LIST = new List<Models.Ventas_Detalles>();
            SalesGrid.DataSource = VENTA_DETALLE_LIST;
            string cmd = "SELECT ID, Descripcion FROM unidades WHERE Activa=1;";
            UnidadLu.DataSource = LocalConnection.GetDataTable(cmd);
            FocusTimer.Start();

            acceptButon.Click += new EventHandler(NewProductScanned);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UPCTx.Focus();
            if (!ValidarLicencia())
            {
                /*licencia invalida*/
                this.Close();
            }
            VigLb.Caption += CurrentLicence.Vigencia.ToString("dd-MM-yyyy");
            int intento = 1;
            DialogResult dr;
            Logon l = new Logon(new Config().DATABASE_PATH,true);
        OtroIntento: dr = l.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (l.ReadedUser == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Cuenta errornea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (intento >= 3)
                        this.Close();
                    intento++;
                    goto OtroIntento;
                }
                else
                {
                    CURRENT_USER = l.ReadedUser;
                    UserRLabel.Caption = "Bienvenido: " + CURRENT_USER.Nombre;
                }
            }
            else
            {
                MessageBox.Show("Debe registrarse para ingresar");
                this.Close();
            }
            l.Dispose();
            /*ocultar botones de administrador*/
            ConfigBt.Visibility = CURRENT_USER.isAdmin == 1 ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            ReportsBt.Visibility = CURRENT_USER.isAdmin == 1 ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;

            DownLoadData();
            GetLastSync();
            SetVisualConfigs();
        }
        private void GetLastSync()
        {
            string cmd = "SELECT LastSync FROM config";
            var row = LocalConnection.GetFirstRow(cmd);
            LSynctLb.Caption = $"Ultima Sincronizacion: {row["LastSync"].ToString()}";
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
        private void MainView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.ImageIndex = -1;
                e.Painter.DrawObject(e.Info);
                Rectangle r = e.Bounds;

                Image indicator = new Bitmap(Properties.Resources.delete);
                e.Graphics.DrawImage(indicator, new Rectangle(e.Bounds.X + 10, e.Bounds.Y + 1, indicator.Width, indicator.Height));
                e.Handled = true;
            }
        }
        void SetVisualConfigs()
        {

            DataRow configRow = null;
            string cmd = "SELECT ID, FK_Licencia, FK_Tienda, " +
                                "FK_Almacen, PermiteTeclado, PermiteAgregarProductos, " +
                                "PermiteOtrosMetodosPago, FondoPantalla, MembreteTicket, LastSync " +
                                "FROM config;";
            configRow= LocalConnection.GetFirstRow(cmd);
            /*Set image*/
            if (configRow["FondoPantalla"] ==null)
            {
                /*no existen configuraciones*/
                PicturePic.Image = Properties.Resources.nanoBG;
                /*Escondo las opciones configurables*/
                MainLayout.RowStyles[CONFIG_ROW_INDEX].Height = 0;
                PagosLayout.ColumnStyles[CONFIG_PAGO_COLUMN_INDEX].Width = 0;
            }
            else
            {
                /*llena todo desde la base de datos*/
                try
                {
                    Stream s = new MemoryStream((Byte[])configRow["FondoPantalla"]);
                    PicturePic.Image=Image.FromStream(s);
                }
                catch (Exception) { }
                /*valida si esta permitido o buscar o usar teclado*/
                if (configRow["PermiteTeclado"].ToString() == "0")
                {
                    /*Escondo las opciones configurables*/
                    MainLayout.RowStyles[CONFIG_ROW_INDEX].Height = 0;
                }
                else if (configRow["PermiteAgregarProductos"].ToString() == "0")
                {
                    /*no permite realizar busquedas*/
                    SearchLayout.ColumnStyles[CONFIG_SEARCH_INDEX].Width = 0;
                }
                else
                {
                    /*do nothing*/
                }
                
                /*valida si estan permitidos otros metodos de pago*/
                if (configRow["PermiteOtrosMetodosPago"].ToString() == "0")
                {
                    /*no permite usar teclado*/
                    SearchLayout.ColumnStyles[CONFIG_PAGO_COLUMN_INDEX].Width = 0;
                }
                else
                {
                    /*do nothing*/
                }
            }
            
        }
    }
}
