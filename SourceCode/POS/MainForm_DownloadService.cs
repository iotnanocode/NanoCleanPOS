using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        int TABLES_TO_DOWNLOAD = 1;
        int REPORT_PROGRESS_VALUE = 1;
        private void DownLoadData()
        {
            LoadingBar.EditValue = 0;

            BackgroundWorker downloadWorker = new BackgroundWorker();
            downloadWorker.DoWork += DownLoad_DoWork;
            downloadWorker.WorkerReportsProgress = true;
            downloadWorker.RunWorkerCompleted += downLoad_RunWorkerCompleted;
            downloadWorker.ProgressChanged += downLoad_ProgressChanged;
            this.Cursor = Cursors.WaitCursor;
            downloadWorker.RunWorkerAsync();
        }

        private void DownLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker downloadWorker = (BackgroundWorker)sender;
            DescargarDatos(downloadWorker);
        }

        private void DescargarDatos(BackgroundWorker downloadWorker)
        {
            /*Descargar almacenes*/
            string cmd = "SELECT ID, FK_Categoria, Descripcion, Ubicacion, FK_Licencia, Activa " +
                         $"FROM almacenes WHERE FK_Licencia = '{CurrentLicence.ID}' OR FK_Licencia is null; ";
            var dtAlmacenes = ac.ObtieneTabla(cmd);
            cmd = "DELETE * FROM  almacenes";
            /*borro almacenes locales*/
            LocalConnection.ExecuteScalar(cmd);
            cmd = "INSERT INTO almacenes (SELECT ID, FK_Categoria, Descripcion, Ubicacion, FK_Licencia, Activa) VALUES ";
            foreach (DataRow item in dtAlmacenes.Rows)
            {
                cmd+=$"('{item["ID"]}','{item["FK_Categoria"]}','{item["Descripcion"]}','{item["Ubicacion"]}','{item["FK_Licencia"]}','{item["Activa"]}'),";
            }
            cmd.Remove(cmd.LastIndexOf(","));
            LocalConnection.ExecuteScalar(cmd);
            downloadWorker.ReportProgress(REPORT_PROGRESS_VALUE);
        }
        private void downLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LoadingBar.EditValue = ((int)LoadingBar.EditValue) + REPORT_PROGRESS_VALUE;
        }
        private void downLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker downloadWorker = (BackgroundWorker)sender;
            downloadWorker.ProgressChanged -= downLoad_ProgressChanged;
            UPCTx.Focus();
            LoadingBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Cursor = Cursors.Default;
            MessageBox.Show("Sincronizacion completa");
        }
    }
}
