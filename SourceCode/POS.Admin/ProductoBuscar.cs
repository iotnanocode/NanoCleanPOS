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
    public partial class ProductoBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        string CATEGORIA_ENVASES = "6bdd11c0-cb26-11ec-9d64-0242ac120002";
        Licencia CurrentLicence;
        public ProductoBuscar(Licencia CurrentLicence)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.CurrentLicence = CurrentLicence;
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion FROM categorias_productos";
            CatLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion, Activa FROM unidades;";
            UnidadLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = $"SELECT ID, UPC, Descripcion FROM productos WHERE FK_Categoria ='{CATEGORIA_ENVASES}' AND FK_Licencia='{CurrentLicence.ID}';";
            EnvaseLu.DataSource = ac.ObtieneTabla(cmd);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.RowHandle);
            string AlmacenID = r["ID"].ToString();

            Producto t = new Producto(CurrentLicence, AlmacenID);
            t.MdiParent = this.MdiParent;
            t.Show();
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = $"SELECT ID, FK_Categoria, UPC, Descripcion, Presentacion, Costo, Precio, FK_Envase, FK_Unidad FROM productos WHERE  FK_Licencia='{CurrentLicence.ID}';";
            ProductosGrid.DataSource = ac.ObtieneTabla(cmd);
        }
    }
}