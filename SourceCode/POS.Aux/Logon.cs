using POS.Aux.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Aux
{
    public partial class Logon : Form
    {
        public  DataRow rowUser;
        AccessConeccion ac;
        string DATABASE_PATH;
        public User ReadedUser;
        SQLiteAux LocalConnection;
        bool CHECK_LOCAL;
        public Logon(string DATABASE_PATH="",bool CHECK_LOCAL=false)
        {
            InitializeComponent();
            ac = new AccessConeccion();
            this.DATABASE_PATH = DATABASE_PATH;
            this.CHECK_LOCAL = CHECK_LOCAL;
            LocalConnection = new SQLiteAux(DATABASE_PATH);
        }

        private void OKbt_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT ID, FK_Licencia, Nombre, Usuario, Pwd, FK_Tienda, isAdmin, Activa  " +
                        "FROM users " +
                        "WHERE Pwd = '" + PwdText.Text + "'  AND Usuario='" + UserText.Text + "'";
            if (CHECK_LOCAL && existsLocalUsers())
            {
                rowUser = LocalConnection.GetFirstRow(cmd);
            }
            else
            {
                rowUser = ac.GetFirstRow(cmd);
            }
            if (null!=rowUser)
            {
                int uxActiva=0;
                Int32.TryParse(rowUser["Activa"].ToString(), out uxActiva);

                int auxisAdmin=0;
                Int32.TryParse(rowUser["isAdmin"].ToString(), out auxisAdmin);
                /*existe el usuario*/
                ReadedUser = new User()
                {
                    Activa = uxActiva,
                    FK_Licencia = rowUser["FK_Licencia"].ToString(),
                    FK_Tienda = rowUser["FK_Tienda"].ToString(),
                    ID = rowUser["ID"].ToString(),
                    isAdmin = auxisAdmin,
                    Nombre = rowUser["Nombre"].ToString(),
                    Pwd = rowUser["Pwd"].ToString(),
                    Usuario = rowUser["Usuario"].ToString()
                };
            }
            this.Close();
        }

        private bool existsLocalUsers()
        {
            string cmd = "SELECT ID FROM users;";
            var dtUsers = LocalConnection.GetDataTable(cmd);
            return dtUsers !=null;
        }
    }
}
