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

namespace POS.Admin
{
    public partial class UsuarioBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        public UsuarioBuscar()
        {
            InitializeComponent();
            ac = new AccessConeccion();
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = "SELECT ID, Nombre, Usuario, Pwd, FK_Tienda, Activa FROM users;";
            UsuariosGrid.DataSource = ac.ObtieneTabla(cmd);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.RowHandle);
            string TiendaID = r["ID"].ToString();

            Usuario t = new Usuario(TiendaID);
            t.MdiParent = this.MdiParent;
            t.Show();
        }
    }
}