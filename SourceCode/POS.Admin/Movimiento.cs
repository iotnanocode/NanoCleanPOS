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
    public partial class Movimiento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        FuncionesPOS fp;
        FuncionesComunes fc;
        DataTable AlmacenesDt;
        string CLASIFICACION_ENTRADAS = "420c22d6-cb27-11ec-9d64-0242ac120002";
        public Movimiento()
        {
            InitializeComponent();
            ac = new AccessConeccion();
            fp = new FuncionesPOS();
            fc = new FuncionesComunes();
            Inicializa();
        }
        private void Inicializa()
        {
            string cmd = "SELECT ID, FK_Categoria, UPC, Descripcion, Presentacion, Costo, Precio, FK_Envase, FK_Unidad, Activa FROM productos WHERE ACtiva=1;";
            ProductoLu.Properties.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion, Activa FROM unidades;";
            UnidadLu.Properties.DataSource = ac.ObtieneTabla(cmd);

            cmd = $"SELECT ID, FK_Categoria, Descripcion, Ubicacion, Activa FROM almacenes WHERE Activa=1;";
            AlmacenesDt = ac.ObtieneTabla(cmd);

            OrigenLu.Properties.DataSource = AlmacenesDt;
            DestinoLu.Properties.DataSource = AlmacenesDt;

            FechaDt.EditValue = DateTime.Today;
        }

        private void ProductoLu_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView prodRow = (DataRowView) ProductoLu.GetSelectedDataRow();
            UnidadLu.EditValue = prodRow["FK_Unidad"];
            CostoTx.EditValue = prodRow["Costo"];
        }

        private void OrigenLu_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView origenRow = (DataRowView)OrigenLu.GetSelectedDataRow();
            if (CLASIFICACION_ENTRADAS == origenRow["FK_Categoria"].ToString())
            {
                /*es una compra*/
                CostoTx.Enabled = true;
            }
            else
            {
                /*es un movimiento y el costo se obtendra forzosamente del promedio del almacen origen*/
                string cmd = $"SELECT CostoPromedio FROM nanoclean.existencias WHERE FK_Producto='{ProductoLu.EditValue}' AND FK_Almacen='{OrigenLu.EditValue}';";
                CostoTx.Enabled = false;
                CostoTx.EditValue = ac.ExecutaEscalar(cmd).ToString();
            }
        }

        private void SaveBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fc.ValidaCombo(ProductoLu);
                fc.ValidaTxtFloat(CantTx);
                fc.ValidaCombo(UnidadLu);
                fc.ValidaTxtFloat(CostoTx);
                fc.ValidaCombo(OrigenLu);
                fc.ValidaCombo(DestinoLu);
            }
            catch(Exception ex)
            {
                return;
            }
            MoverInventario(ProductoLu.EditValue.ToString(), float.Parse(CantTx.Text), UnidadLu.EditValue.ToString(), 
                                float.Parse(CostoTx.Text), OrigenLu.EditValue.ToString(), DestinoLu.EditValue.ToString(), FechaDt.DateTime);
            MessageBox.Show("Almacenado, Gracias");
            this.Close();
        }

        private void MoverInventario(string IDProducto, float Cantidad, string IDUnidad , float Costo, string IDAlmacenOrigen, string IDAlmacenDestino, DateTime Fecha)
        {
            string cmd = $"CALL sp_MoverInventario('{IDProducto}', '{Cantidad}','{IDUnidad}', '{Costo}', '{IDAlmacenOrigen}','{IDAlmacenDestino}', '{Fecha.ToString("yyyy-MM-dd HH:mm")}'); ";
            ac.ExecutaEscalar(cmd);
        }
    }
}