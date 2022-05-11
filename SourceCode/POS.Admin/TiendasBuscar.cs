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
    public partial class TiendasBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        DataTable TiendasDt;
        Licencia CurrentLicence;
        public TiendasBuscar(Licencia CurrentLicence)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.CurrentLicence = CurrentLicence;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = $"SELECT ID, Nombre, Activa FROM tiendas WHERE FK_Licencia='{CurrentLicence.ID}';";
            TiendasDt=ac.ObtieneTabla(cmd);
            TiendasGrid.DataSource = TiendasDt;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.RowHandle);
            string TiendaID = r["ID"].ToString();

            Tienda t = new Tienda(CurrentLicence, TiendaID);
            t.MdiParent = this.MdiParent;
            t.Show();
        }
    }
}