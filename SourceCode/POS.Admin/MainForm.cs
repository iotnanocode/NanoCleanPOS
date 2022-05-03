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

namespace POS.Admin
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}