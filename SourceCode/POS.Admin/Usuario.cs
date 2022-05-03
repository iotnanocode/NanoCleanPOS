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
    public partial class Usuario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AccessConeccion ac;
        FuncionesComunes fc;
        string IDUser;
        public Usuario(string IDUser="")
        {
            InitializeComponent();
            this.IDUser = IDUser;
            ac = new AccessConeccion();
            fc = new FuncionesComunes();
            Inicializa();
        }

        private void Inicializa()
        {
            string cmd = "SELECT ID, Nombre FROM tiendas WHERE Activa=1;";
            TiendaLu.Properties.DataSource = ac.ObtieneTabla(cmd);
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDUser))
            {
                /*editar usuario*/
                string cmd = $"SELECT ID, Nombre, Usuario, Pwd, FK_Tienda, Activa FROM users WHERE ID='{IDUser}';";
                var row = ac.GetFirstRow(cmd);

                NombreTx.Text = row["Nombre"].ToString();
                UsuarioTx.Text = row["Usuario"].ToString();
                TiendaLu.EditValue = row["FK_Tienda"].ToString();
            }
            else
            {
                /*do nothing*/
            }
        }

        private void SaveBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                fc.ValidaTxtNull(NombreTx);
                fc.ValidaTxtNull(UsuarioTx);
                fc.ValidaCombo(TiendaLu);
            }
            catch (Exception)
            {
                return;
            }
            if (string.IsNullOrEmpty(IDUser))
            {
                /*es una nueva tienda*/
                string newID = Guid.NewGuid().ToString();
                string cmd = $"INSERT INTO users (ID, Nombre, Usuario,Pwd,FK_Tienda,Activa) " +
                              $"VALUES('{newID}','{NombreTx.Text}','{UsuarioTx.Text}',AES_ENCRYPT('{PwdTx.Text} ',UNHEX('F3229A0B371ED2D9441B830D21A390C3')),'{TiendaLu.EditValue}',1);";               
                ac.ExecutaEscalar(cmd);
                IDUser = newID;
                MessageBox.Show("Almacenado");
            }
            else
            {
                /*es una actualizacion*/
                string cmd = "";
                if (string.IsNullOrEmpty(PwdTx.Text))
                {
                    /*cambia el password*/
                    cmd= $"UPDATE users SET Nombre = '{NombreTx.Text}',Usuario = '{UsuarioTx.Text}',Pwd = AES_ENCRYPT('{PwdTx.Text} ',UNHEX('F3229A0B371ED2D9441B830D21A390C3')),FK_Tienda = '{TiendaLu.EditValue}' WHERE ID = '{IDUser}';                ; ";
                } 
                else
                {
                    /*no cambia el password*/
                    cmd= $"UPDATE users SET Nombre = '{NombreTx.Text}',Usuario = '{UsuarioTx.Text}',FK_Tienda = '{TiendaLu.EditValue}' WHERE ID = '{IDUser}';                ; ";
                }
                ac.ExecutaEscalar(cmd);
                MessageBox.Show("Almacenado");
                this.Close();
            }
        }

        private void DeleteBt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro?", "Estas seguro?", MessageBoxButtons.YesNo))
            {
                string cmd = $"UPDATE users SET Activa = 0 WHERE ID = '{IDUser}';";
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