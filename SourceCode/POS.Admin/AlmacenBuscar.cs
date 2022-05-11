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
    
    public partial class AlmacenBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        Licencia CurrentLicence;
        public AlmacenBuscar(Licencia CurrentLicence)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.CurrentLicence = CurrentLicence;
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion, `Virtual` FROM almacenes_clasificacion;";
            CatLu.DataSource = ac.ObtieneTabla(cmd);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = $"SELECT ID, FK_Categoria, Descripcion, Ubicacion, Activa FROM almacenes WHERE FK_Licencia ='{CurrentLicence.ID}';";
            AlmacenesGrid.DataSource = ac.ObtieneTabla(cmd);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.RowHandle);
            string AlmacenID = r["ID"].ToString();

            Almacen t = new Almacen(CurrentLicence,AlmacenID);
            t.MdiParent = this.MdiParent;
            t.Show();
        }
    }
}