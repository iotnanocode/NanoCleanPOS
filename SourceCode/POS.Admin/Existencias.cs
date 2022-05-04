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
    public partial class Existencias : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        public Existencias()
        {
            InitializeComponent();
            ac = new AccessConeccion();
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion FROM productos";
            ProductoLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion FROM unidades;";
            UnidadLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion FROM almacenes;";
            AlmacenLu.DataSource = ac.ObtieneTabla(cmd);
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = "SELECT ID, FK_Producto, FK_Almacen, Cantidad, FK_Unidad, CostoPromedio, Activa FROM existencias WHERE  NOT FK_Almacen  ='8f792a99-ec4f-45c2-a830-a238d412bfe6' AND NOT FK_Almacen ='1c069676-74f5-4e96-9b4f-925e90d6ca11'; ";
            ExistenciasGrid.DataSource = ac.ObtieneTabla(cmd);
        }
    }
}