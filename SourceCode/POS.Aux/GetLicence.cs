using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Aux.Models;

namespace POS.Aux
{
    public partial class GetLicence : Form
    {
        string BDPath;
        public Licencia remoteLicence;
        public GetLicence(string BDPath)
        {
            InitializeComponent();
            this.BDPath = BDPath;
        }
        public Licencia ObtenerLicencia()
        {
            var lite = new SQLiteAux(BDPath);
            string cmd = $"SELECT ID,Nombre,Vigencia FROM licencias";
            var row = lite.GetFirstRow(cmd);
            Licencia lic = new Licencia();
            if (row!=null)
            {
                lic.ID = row["ID"].ToString();
                lic.Nombre = row["Nombre"].ToString();
                lic.Vigencia = DateTime.Parse(row["Vigencia"].ToString());
            }
            else
            {
                /*do nothing*/
            }
            return lic;
        }

        private void AceptBt_Click(object sender, EventArgs e)
        {
            FuncionesComunes fc = new FuncionesComunes();
            try
            {
                fc.ValidaTxtNull(LicenceTx);
            }
            catch (Exception)
            {
                return;
            }
            AccessConeccion ac = new AccessConeccion();
            string cmd = $"SELECT ID, Nombre, Vigencia FROM licencias WHERE ID='{LicenceTx.Text}'";
            var row = ac.GetFirstRow(cmd);
            remoteLicence = new Licencia();
            if (null!=row)
            {
                /*la licencia existe*/
                remoteLicence.ID = row["ID"].ToString();
                remoteLicence.Nombre = row["Nombre"].ToString();
                remoteLicence.Vigencia=(DateTime)row["Vigencia"];
            }
            else
            {
                /*do nothing*/
            }
            this.Close();
        }
    }
}
