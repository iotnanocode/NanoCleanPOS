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
    public partial class MovimientoBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        public MovimientoBuscar()
        {
            InitializeComponent();
            ac = new AccessConeccion();
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion FROM productos";
            ProdLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion FROM unidades;";
            UnidadLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion FROM almacenes;";
            AlmacenLu.DataSource = ac.ObtieneTabla(cmd);
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = "SELECT ID, FK_Producto, FK_AlmacenOrigen, FK_AlmacenDestino, Fecha, Cantidad, CostoUnitario, FK_Unidad, Activa FROM movimientos";
             MovimientosGrid.DataSource = ac.ObtieneTabla(cmd);
        }
    }
}