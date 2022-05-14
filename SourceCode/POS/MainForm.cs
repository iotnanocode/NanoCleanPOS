using DevExpress.XtraBars;
using POS.Aux;
using POS.Aux.Models;
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
        User user;
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
            throw new NotImplementedException();
        }

    }
}