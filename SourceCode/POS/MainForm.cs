using DevExpress.XtraBars;
using POS.Aux;
using POS.Aux.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        AccessConeccion ac;
        FuncionesComunes fc;
        Licencia CurrentLicence;
        string User;
        public MainForm()
        {
            InitializeComponent();
            ac = new AccessConeccion();
            fc = new FuncionesComunes();
            StatusLabel.Caption = this.StatusLabel.Caption + " " + ((object)FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion).ToString();
            Inicializa();
        }

        private void Inicializa()
        {
            Button acceptButon = new Button();
            this.AcceptButton = acceptButon;
            acceptButon.Click+= new EventHandler(NewProductScanned);
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

        private void NewProductScanned(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}