using DevExpress.XtraBars;
using POS.Aux;
using POS.Aux.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ConfigForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SQLiteAux localConnection;
        FuncionesComunes fc;
        string CAT_PUNTOS_VENTA = "60772216-cb27-11ec-9d64-0242ac120002";
        Licencia CURRENT_LICENCE;
        POSConfig ConfigData;
        byte[] EncabezadoBytes, FondoBytes;
        public ConfigForm(Licencia CURRENT_LICENCE)
        {
            InitializeComponent();
            localConnection = new SQLiteAux(new Config().DATABASE_PATH);
            fc = new FuncionesComunes();
            this.CURRENT_LICENCE = CURRENT_LICENCE;
            Inicializa();
            CargarDatos();
        }

        private void CargarDatos()
        {
            string cmd = "SELECT ID, FK_Licencia, FK_Tienda, FK_Almacen, OchoMM,PermiteTeclado, PermiteAgregarProductos, " +
                "PermiteOtrosMetodosPago, FondoPantalla, MembreteTicket,LastSync " +
                "FROM config; ";
            var configRow = localConnection.GetFirstRow(cmd);
            ConfigData = new POSConfig()
            {
                ID = configRow["ID"].ToString(),
                FK_Licencia = configRow["FK_Licencia"].ToString(),
                LastSync = configRow["LastSync"].ToString()
            };
            if (!string.IsNullOrEmpty(configRow["FondoPantalla"].ToString()))
            {
                TiendaLu.EditValue = configRow["FK_Tienda"].ToString();
                AlmacenLu.EditValue = configRow["FK_Almacen"].ToString();

                ImpresoraRg.EditValue = fc.GetBoolValue(configRow["OchoMM"]);
                TecladoTs.EditValue = fc.GetBoolValue(configRow["PermiteTeclado"]);
                ProductosTs.EditValue = fc.GetBoolValue(configRow["PermiteAgregarProductos"]);
                MetodosPagoTs.EditValue = fc.GetBoolValue(configRow["PermiteOtrosMetodosPago"]);

                try
                {
                    Stream s = new MemoryStream((Byte[])configRow["FondoPantalla"]);
                    FondoPic.Image = Image.FromStream(s);
                    FondoBytes = (Byte[])configRow["FondoPantalla"];
                }
                catch (Exception) { }

                try
                {
                    Stream s = new MemoryStream((Byte[])configRow["MembreteTicket"]);
                    EncabezadoPic.Image = Image.FromStream(s);
                    EncabezadoBytes = (Byte[])configRow["MembreteTicket"];
                }
                catch (Exception) { }
            }
            else
            {
                /*do nothing*/
            }
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion, Ubicacion " +
                         $"FROM almacenes where FK_Categoria = '{CAT_PUNTOS_VENTA}' AND FK_Licencia = '{CURRENT_LICENCE.ID}' AND Activa = 1; ";
            AlmacenLu.Properties.DataSource = localConnection.GetDataTable(cmd);

            cmd = $"SELECT ID, Nombre FROM tiendas where FK_Licencia='{CURRENT_LICENCE.ID}' ANd Activa=1;";
            TiendaLu.Properties.DataSource = localConnection.GetDataTable(cmd);
        }

        private void SaveBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fc.ValidaLookUp(TiendaLu);
                fc.ValidaLookUp(AlmacenLu);
            }
            catch (Exception)
            {

                return;
            }

            string cmd = $"UPDATE config " +
                         $"SET ID = '{ConfigData.ID}',FK_Licencia = '{ConfigData.FK_Licencia }',FK_Tienda = '{TiendaLu.EditValue }'," +
                         $"FK_Almacen = '{AlmacenLu.EditValue}',PermiteTeclado = '{fc.GetBoolValue(TecladoTs) }',PermiteAgregarProductos = '{fc.GetBoolValue(ProductosTs) }'," +
                         $"PermiteOtrosMetodosPago = '{fc.GetBoolValue(MetodosPagoTs) }',FondoPantalla = @FondoPantalla,MembreteTicket = @Membrete," +
                         $"OchoMM = '{fc.GetBoolValue(ImpresoraRg) }',LastSync = '{ConfigData.LastSync }'";

            List<CommandParameter> commandParameters = new List<CommandParameter>();
            commandParameters.Add(new CommandParameter()
            {
                ParameterName="@FondoPantalla",
                ParameterValue=FondoBytes
            });

            commandParameters.Add(new CommandParameter()
            {
                ParameterName="@Membrete",
                ParameterValue=EncabezadoBytes
            });

            localConnection.ExecuteScalar(cmd, commandParameters);
            MessageBox.Show("Configuracion Almacenada, gracias");
            this.Close();
        }

        private void EncabezadoPic_Click(object sender, EventArgs e)
        {
            if (OFImage.ShowDialog() == DialogResult.OK)
            {
                EncabezadoPic.Image = Image.FromFile(OFImage.FileName);
                EncabezadoBytes = File.ReadAllBytes(OFImage.FileName);
            }
        }

        private void FondoPic_Click(object sender, EventArgs e)
        {
            if (OFImage.ShowDialog() == DialogResult.OK)
            {
                FondoPic.Image = Image.FromFile(OFImage.FileName);
                FondoBytes = File.ReadAllBytes(OFImage.FileName);               
            }

        }
    }
}