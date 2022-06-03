using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using POS.Aux;
using POS.Aux.Models;
using POS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        AccessConeccion ac;
        FuncionesComunes fc;
        Licencia CurrentLicence;
        SQLiteAux LocalConnection;
        User CURRENT_USER;
        bool PERMITE_AGREGAR;
        List<Ventas_Detalles> VENTA_DETALLE_LIST;
        public MainForm()
        {
            InitializeComponent();
            ac = new AccessConeccion();
            fc = new FuncionesComunes();
            LocalConnection = new SQLiteAux(new Config().DATABASE_PATH);
            StatusLabel.Caption = this.StatusLabel.Caption + " " + ((object)FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion).ToString();
            Inicializa();
        }      

        private void NewProductScanned(object sender, EventArgs e)
        {
            SellProducto(UPCTx.Text);
            Console.Beep();
        }
        void SellProducto(string ProductUPC)
        {
            /*find the product*/
            string cmd = $"SELECT ID, FK_Licencia, FK_Categoria, UPC, Descripcion, Presentacion, Costo, Precio, FK_Envase, FK_Unidad, Activa FROM productos WHERE UPC='{ProductUPC}';";
            var rowProducto = LocalConnection.GetFirstRow(cmd);
            UPCTx.EditValue = "";
            if (rowProducto != null)
            {
                Ventas_Detalles ventas_Detalles = new Ventas_Detalles()
                {
                    Cantidad = 1,
                    Descripcion = rowProducto["Descripcion"].ToString(),
                    FK_Producto = rowProducto["ID"].ToString(),
                    FK_Unidad = rowProducto["FK_Unidad"].ToString(),
                    Precio = float.Parse(rowProducto["Precio"].ToString())
                };
                AddProduct(ventas_Detalles);
                /*revisar si hay que agregar ademas un envase*/
                cmd = $"SELECT UPC FROM productos WHERE ID='{rowProducto["FK_Envase"].ToString()}';";
                var upcEnvase = LocalConnection.GetSingleValue(cmd);
                SellProducto(upcEnvase);
            }
            else
            {
                /*do nothing*/
            }
            SalesGrid.DataSource = VENTA_DETALLE_LIST.Where(x => x.ID.Length > 0);
        }

        private void AddProduct(Ventas_Detalles ventas_Detalles)
        {
            bool isDuplicated = false;
            foreach (var item in VENTA_DETALLE_LIST)
            {
                if (item.FK_Producto==ventas_Detalles.FK_Producto)
                {
                    /*item repetido*/
                    item.Cantidad = item.Cantidad + 1;
                    isDuplicated = true;
                }
                else
                {
                    /*do nothing*/
                }
            }
            if (!isDuplicated)
            {
                VENTA_DETALLE_LIST.Add(ventas_Detalles);
            }
            else
            {
                /*do nothing*/
            }
        }

        private void ConfigBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConfigForm cf = new ConfigForm(CurrentLicence);
            cf.ShowDialog();
            SetVisualConfigs();
        }

        private void FocusTimer_Tick(object sender, EventArgs e)
        {
            if (!SearchTx.Focused&& !UPCTx.Focused)
            {
                /*para asegurarnos de regresar el focus*/
                UPCTx.Focus();
            }
            else
            {
                /*do nothing*/
            }
        }

        private void MainView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string ID = (sender as GridView).GetFocusedRowCellValue("ID").ToString();
            Ventas_Detalles deletedItem = null;
            foreach (var item in VENTA_DETALLE_LIST)
            {
                if (item.ID==ID)
                {
                    /*esta es la fila a eliminar*/
                    item.Cantidad--;
                    if (item.Cantidad==0)
                    {
                        /*hay que borrar la fila*/
                        deletedItem = item;
                    }
                    else
                    {
                        /*do nothing*/
                    }
                }
            }
            if (deletedItem != null)
            {
                /*hay un item a eliminar*/
                VENTA_DETALLE_LIST.Remove(deletedItem);
            }
            SalesGrid.DataSource = VENTA_DETALLE_LIST.Where(x => x.ID.Length > 0);
        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            VENTA_DETALLE_LIST.Clear();
            SalesGrid.DataSource = VENTA_DETALLE_LIST.Where(x => x.ID.Length > 0);
        }
    }
}