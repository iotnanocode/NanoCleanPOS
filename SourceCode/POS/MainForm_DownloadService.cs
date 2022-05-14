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
        int DOWNLOAD_REPORT_PROGRESS_VALUE = 11;
        private void DownLoadData()
        {
            LoadingBar.EditValue = 0;
            LoadingBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
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
            Descargar("almacenes",true);
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("almacenes_clasificacion");
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("categorias_productos");
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("clientes",true);
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargarlicencia();
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("productos",true);
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("tiendas",true);
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("unidades");
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
            Descargar("users",true);
            downloadWorker.ReportProgress(DOWNLOAD_REPORT_PROGRESS_VALUE);
        }

        private void Descargar(string Tabla,bool WithLicence=false)
        {
            /*Descargar */
            string cmd = "SELECT * " +
                         $"FROM {Tabla} ";
            if (WithLicence)
            {
                cmd+=$"WHERE FK_Licencia='{CurrentLicence.ID}' OR FK_Licencia IS NULL;";
            }
            else
            {
                /*do nothing*/
            }
                         
            var dtRemota = ac.ObtieneTabla(cmd);
            cmd = $"DELETE * FROM  {Tabla}";
            /*borro locales*/
            LocalConnection.ExecuteScalar(cmd);
            /*genero comando insert*/
            LocalConnection.InsertaDataTable(dtRemota, Tabla);
        }
        private void Descargarlicencia()
        {
            /*Descargar */
            string cmd = $"SELECT Vigencia FROM licencias WHERE ID='{CurrentLicence.ID}' ";
            var value = (DateTime)ac.ExecutaEscalar(cmd);
            cmd = $"UPDATE licencias SET Vigencia = '{value.ToString("yyyy-MM-dd HH:mm")}'";
            /*actualizo locales*/
            LocalConnection.ExecuteScalar(cmd);
        }
        private void downLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LoadingBar.EditValue = ((int)LoadingBar.EditValue) + DOWNLOAD_REPORT_PROGRESS_VALUE;
        }
        private void downLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker downloadWorker = (BackgroundWorker)sender;
            downloadWorker.ProgressChanged -= downLoad_ProgressChanged;
            UPCTx.Focus();
            LoadingBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Cursor = Cursors.Default;
            string cmd = $"UPDATE config SET FK_Licencia='{CurrentLicence.ID}',LastSync='{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}'";
            LocalConnection.ExecuteScalar(cmd);
            MessageBox.Show("Sincronizacion completa");
            GetLastSync();
        }
    }
}
