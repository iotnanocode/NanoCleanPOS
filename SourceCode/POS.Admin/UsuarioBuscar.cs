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
using POS.Aux.Models;

namespace POS.Admin
{
    public partial class UsuarioBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        Licencia CurrentLicence;
        public UsuarioBuscar(Licencia CurrentLicence)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.CurrentLicence = CurrentLicence;
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = $"SELECT ID, FK_Licencia, Nombre, Activa FROM tiendas  WHERE FK_Licencia='{CurrentLicence.ID}';";
            TiendaLu.DataSource = ac.ObtieneTabla(cmd);
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = $"SELECT ID, Nombre, Usuario, Pwd, FK_Tienda,isAdmin, Activa FROM users WHERE FK_Licencia='{CurrentLicence.ID}';";
            UsuariosGrid.DataSource = ac.ObtieneTabla(cmd);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.RowHandle);
            string TiendaID = r["ID"].ToString();

            Usuario t = new Usuario(CurrentLicence, TiendaID);
            t.MdiParent = this.MdiParent;
            t.Show();
        }
    }
}