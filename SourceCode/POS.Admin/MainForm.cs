using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Aux;
using System.Diagnostics;
using System.Reflection;
using POS.Aux.Models;
using System.IO;
using System.Data.SQLite;

namespace POS.Admin
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
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
        }

        private void NewTiendaBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tienda t = new Tienda(CurrentLicence);
            t.MdiParent = this;
            t.Show();
        }
        private void ribbon_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            try
            {
                Ribbon.SelectedPage = Ribbon.MergedPages[0];
            }
            catch (Exception) { }
        }

        private void TiendasBuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            TiendasBuscar tiendasBuscar = new TiendasBuscar(CurrentLicence);
            tiendasBuscar.MdiParent = this;
            tiendasBuscar.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsuarioBuscar usuarioBuscar = new UsuarioBuscar(CurrentLicence);
            usuarioBuscar.MdiParent = this;
            usuarioBuscar.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Usuario usuario = new Usuario(CurrentLicence);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(!ValidarLicencia())
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
                    File.WriteAllBytes(config.DATABASE_PATH, Properties.Resources.nanoPOS_admin);
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
            else if(CurrentLicence.Vigencia > DateTime.Today)
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

        private void NewAlmBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            Almacen almacen = new Almacen(CurrentLicence);
            almacen.MdiParent = this;
            almacen.Show();
        }

        private void BuscarAlmBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            AlmacenBuscar almacenBuscar = new AlmacenBuscar(CurrentLicence);
            almacenBuscar.MdiParent = this;
            almacenBuscar.Show();
        }

        private void BuscarProductoBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductoBuscar nuevaVentana = new ProductoBuscar(CurrentLicence);
            nuevaVentana.MdiParent = this;
            nuevaVentana.Show();
        }

        private void NewProductBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            Producto nuevaVentana = new Producto(CurrentLicence);
            nuevaVentana.MdiParent = this;
            nuevaVentana.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Movimiento nuevaVentana = new Movimiento(CurrentLicence,User);
            nuevaVentana.MdiParent = this;
            nuevaVentana.Show();
        }

        private void BuscarMovBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            MovimientoBuscar nuevaVentana = new MovimientoBuscar(CurrentLicence);
            nuevaVentana.MdiParent = this;
            nuevaVentana.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Existencias nuevaVentana = new Existencias(CurrentLicence);
            nuevaVentana.MdiParent = this;
            nuevaVentana.Show();
        }
    }
}