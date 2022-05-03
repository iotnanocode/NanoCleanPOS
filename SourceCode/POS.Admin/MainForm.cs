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

namespace POS.Admin
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        FuncionesComunes fc;
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
            Tienda t = new Tienda();
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
            TiendasBuscar tiendasBuscar = new TiendasBuscar();
            tiendasBuscar.MdiParent = this;
            tiendasBuscar.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsuarioBuscar usuarioBuscar = new UsuarioBuscar();
            usuarioBuscar.MdiParent = this;
            usuarioBuscar.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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

        private void NewAlmBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.MdiParent = this;
            almacen.Show();
        }

        private void BuscarAlmBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            AlmacenBuscar almacenBuscar = new AlmacenBuscar();
            almacenBuscar.MdiParent = this;
            almacenBuscar.Show();
        }
    }
}