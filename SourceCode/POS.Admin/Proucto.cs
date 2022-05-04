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
    public partial class Producto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        FuncionesComunes fc;
        string IDProducto;
        string CATEGORIA_ENVASES = "6bdd11c0-cb26-11ec-9d64-0242ac120002";
        public Producto(string IDProducto="")
        {
            InitializeComponent();
            this.IDProducto = IDProducto;
            ac = new AccessConeccion();
            fc = new FuncionesComunes();
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion FROM categorias_productos";
            CatLu.Properties.DataSource = ac.ObtieneTabla(cmd);

            cmd = "SELECT ID, Descripcion, Activa FROM unidades;";
            UnidadLu.Properties.DataSource = ac.ObtieneTabla(cmd);

            cmd = $"SELECT ID, UPC, Descripcion FROM nanoclean.productos WHERE FK_Categoria ='{CATEGORIA_ENVASES}';";
            EnvaseLu.Properties.DataSource = ac.ObtieneTabla(cmd);
        }


        private void SaveBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fc.ValidaCombo(CatLu);
                fc.ValidaCombo(UnidadLu);
                fc.ValidaTxtNull(DescTx);
                fc.ValidaTxtNull(UpcTx);
                fc.ValidaTxtFloat(CostoTx);
                fc.ValidaTxtFloat(PrecioTx);

            }
            catch (Exception)
            {
                return;
            }
            if (string.IsNullOrEmpty(IDProducto))
            {
                /*es una nueva tienda*/
                string newID = Guid.NewGuid().ToString();
                string cmd = $"INSERT INTO productos (ID,FK_Categoria,UPC,Descripcion,Presentacion,Costo,Precio,FK_Envase,FK_Unidad) "+
                             $" VALUES('{newID}','{CatLu.EditValue}','{UpcTx.Text}','{DescTx.Text}','{PresentacionTx.Text}','{CostoTx.EditValue}','{PrecioTx.EditValue}','{EnvaseLu.EditValue}','{UnidadLu.EditValue}');";
                ac.ExecutaEscalar(cmd);
                IDProducto = newID;
                MessageBox.Show("Almacenado");
                this.Close();
            }
            else
            {
                /*es una actualizacion*/
                string  cmd = $"UPDATE productos "+
                                $"SET FK_Categoria = '{CatLu.EditValue}',UPC = '{UpcTx.EditValue}', " +
                                $"Descripcion = '{DescTx.EditValue}',Presentacion = '{PresentacionTx.EditValue}',Costo = '{CostoTx.EditValue}'," +
                                $"Precio = '{PrecioTx.EditValue}',FK_Envase = '{EnvaseLu.EditValue}',FK_Unidad = '{UnidadLu.EditValue}' " +
                                $"WHERE ID = '{IDProducto}';                ; ";
                ac.ExecutaEscalar(cmd);
                MessageBox.Show("Almacenado");
                this.Close();
            }
        }

        private void Proucto_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDProducto))
            {
                /*editar usuario*/
                string cmd = $"SELECT ID, FK_Categoria, UPC, Descripcion, Presentacion, Costo, Precio, FK_Envase, FK_Unidad FROM productos WHERE ID='{IDProducto}';";
                var row = ac.GetFirstRow(cmd);

                CatLu.EditValue = row["FK_Categoria"].ToString();
                UpcTx.EditValue = row["UPC"].ToString();
                DescTx.Text = row["Descripcion"].ToString();
                PresentacionTx.Text = row["Presentacion"].ToString();
                CostoTx.EditValue = row["Costo"].ToString();
                PrecioTx.EditValue = row["Precio"].ToString();
                EnvaseLu.EditValue = row["FK_Envase"].ToString();
                UnidadLu.EditValue = row["FK_Unidad"].ToString();
            }
            else
            {
                /*do nothing*/
            }
        }

        private void DeleteBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro?", "Estas seguro?", MessageBoxButtons.YesNo))
            {
                string cmd = $"UPDATE productos SET Activa = 0 WHERE ID = '{IDProducto}';";
                ac.ExecutaEscalar(cmd);
                MessageBox.Show("Eliminado");
            }
            else
            {
                /*do nothing*/
            }
        }
    }
}