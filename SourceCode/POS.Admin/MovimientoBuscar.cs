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
    public partial class MovimientoBuscar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        Licencia CurrentLicence;
        public MovimientoBuscar(Licencia CurrentLicence)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.CurrentLicence = CurrentLicence;
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = $"SELECT ID, Descripcion FROM productos WHERE FK_Licencia='{CurrentLicence.ID}'";
            ProdLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion FROM unidades;";
            UnidadLu.DataSource = ac.ObtieneTabla(cmd);

            cmd = $"SELECT ID, Descripcion FROM almacenes WHERE FK_Licencia='{CurrentLicence.ID}' OR FK_Licencia IS NULL;";
            AlmacenLu.DataSource = ac.ObtieneTabla(cmd);
        }

        private void BuscarBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string cmd = "SELECT ID, FK_Producto, FK_AlmacenOrigen, FK_AlmacenDestino, Fecha, Cantidad, CostoUnitario, FK_Unidad, Activa " +
                         "FROM vwMovimientos " +
                         $"WHERE FK_LicenciaOrigen='{CurrentLicence.ID}' OR FK_LicenciaDestino='{CurrentLicence.ID}'";
             MovimientosGrid.DataSource = ac.ObtieneTabla(cmd);
        }
    }
}