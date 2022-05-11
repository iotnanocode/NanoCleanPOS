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
    public partial class Existencias : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        Licencia CurrentLicence;
        public Existencias(Licencia CurrentLicence)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.CurrentLicence = CurrentLicence;
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = $"SELECT ID, Descripcion FROM productos WHERE FK_Licencia = '{CurrentLicence.ID}'";
            ProductoLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion FROM unidades;";
            UnidadLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = $"SELECT ID, Descripcion FROM almacenes WHERE FK_Licencia = '{CurrentLicence.ID}';";
            AlmacenLu.DataSource = ac.ObtieneTabla(cmd);
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = $"SELECT ID, FK_Producto, FK_Almacen, Cantidad, FK_Unidad, CostoPromedio, Activa FROM vwExistencias WHERE FK_Licencia = '{CurrentLicence.ID}'; ";
            ExistenciasGrid.DataSource = ac.ObtieneTabla(cmd);
        }
    }
}