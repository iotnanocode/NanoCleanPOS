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
        public  DataTable Permisos;
        public string User;
        public string Nombre;
        AccessConeccion ac;
        public Logon()
        {
            InitializeComponent();
            ac = new AccessConeccion();
            Nombre = "";
        }

        private void OKbt_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT Nombre " +
                        "FROM users " +
                        "WHERE CAST(AES_DECRYPT(pwd,UNHEX('F3229A0B371ED2D9441B830D21A390C3')) AS CHAR) = '" + PwdText.Text + "'  AND Usuario='" + UserText.Text + "'";
            Permisos = ac.ObtieneTabla(cmd);
            User = UserText.Text;
            DataTableReader dtr = Permisos.CreateDataReader();
            if (dtr.HasRows)
            {
                dtr.Read();
                Nombre = dtr.GetString(dtr.GetOrdinal("Nombre"));
            }
            this.Close();
        }
    }
}
