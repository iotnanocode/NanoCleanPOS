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
    public partial class Almacen : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FuncionesComunes fc;
        AccessConeccion ac;
        string IDAlmacen;
        Licencia CurrentLicence;
        public Almacen(Licencia CurrentLicence,string IDAlmacen="" )
        {
            InitializeComponent();
            ac = new AccessConeccion();
            fc = new FuncionesComunes();
            this.IDAlmacen = IDAlmacen;
            this.CurrentLicence = CurrentLicence;
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Descripcion FROM almacenes_clasificacion;";
            CatLu.Properties.DataSource = ac.ObtieneTabla(cmd);
        }

        private void SaveBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fc.ValidaTxtNull(DescTx);
                fc.ValidaTxtNull(UbiTx);
                fc.ValidaCombo(CatLu);
            }
            catch (Exception)
            {
                return;
            }
            if (string.IsNullOrEmpty(IDAlmacen))
            {
                /*es una nueva tienda*/
                string newID = Guid.NewGuid().ToString();
                string cmd = $"INSERT INTO almacenes (ID, FK_Categoria,Descripcion,Ubicacion,FK_Licencia,Activa) " +
                             $"VALUES('{newID}','{CatLu.EditValue}','{DescTx.Text}','{UbiTx.Text}','{CurrentLicence.ID}','{1}');";
                ac.ExecutaEscalar(cmd);
                IDAlmacen = newID;
                MessageBox.Show("Almacenado");
            }
            else
            {
                /*es una actualizacion*/
                string cmd = $"UPDATE almacenes SET FK_Categoria = '{CatLu.EditValue}',Descripcion = '{DescTx.Text}', Ubicacion = '{UbiTx.Text}' WHERE ID = '{IDAlmacen}';";


                ac.ExecutaEscalar(cmd);
                MessageBox.Show("Almacenado");
                this.Close();
            }
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDAlmacen))
            {
                /*editar usuario*/
                string cmd = $"SELECT ID, FK_Categoria, Descripcion, Ubicacion,FK_Licencia, Activa FROM almacenes WHERE ID='{IDAlmacen}';";
                var row = ac.GetFirstRow(cmd);

                DescTx.Text = row["Descripcion"].ToString();
                UbiTx.Text = row["Ubicacion"].ToString();
                CatLu.EditValue = row["FK_Categoria"].ToString();
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
                string cmd = $"UPDATE almacenes SET Activa = 0 WHERE ID = '{IDAlmacen}';";
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