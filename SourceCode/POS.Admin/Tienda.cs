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
    public partial class Tienda : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        FuncionesComunes fc;
        string IDTienda;
        Licencia CurrentLicence;
        public Tienda(Licencia CurrentLicence,string IDTienda="")
        {
            InitializeComponent();
            this.IDTienda = IDTienda;
            ac = new AccessConeccion();
            fc = new FuncionesComunes();
            this.CurrentLicence = CurrentLicence;
        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDTienda))
            {
                /*Se llama una tienda existente*/
                CargarTienda();
            }
            else
            {
                /*do nothing*/
            }
        }

        private void CargarTienda()
        {
            string cmd = $"SELECT ID, Nombre, Activa FROM tiendas where FK_Licencia='{CurrentLicence.ID}' AND id='{IDTienda}'";
            var row = ac.GetFirstRow(cmd);
            NombreTx.Text = row["Nombre"].ToString();
        }

        private void SaveBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fc.ValidaTxtNull(NombreTx);
            }
            catch (Exception)
            {
                return;
            }
            if (string.IsNullOrEmpty(IDTienda))
            {
                /*es una nueva tienda*/
                string newID = Guid.NewGuid().ToString();
                string cmd = $"INSERT INTO tiendas (ID,FK_Licencia,Nombre,Activa)VALUES('{newID}','{CurrentLicence.ID}','{NombreTx.Text}','{1}');";
                ac.ExecutaEscalar(cmd);
                IDTienda = newID;
                MessageBox.Show("Almacenado");
            }
            else
            {
                /*es una actualizacion*/
                string cmd = $"UPDATE tiendas SET Nombre = '{NombreTx.Text}' WHERE ID = '{IDTienda}';                 ";
                ac.ExecutaEscalar(cmd);
                MessageBox.Show("Almacenado");
            }
        }

        private void DelBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DialogResult.Yes== MessageBox.Show("Seguro?","Estas seguro?",MessageBoxButtons.YesNo))
            {
                string cmd = $"UPDATE tiendas SET Activa = 0 WHERE ID = '{IDTienda}';";
                ac.ExecutaEscalar(cmd);
                MessageBox.Show("Eliminada");
            }
            else
            {
                /*do nothing*/
            }
        }
    }
}