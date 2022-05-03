using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace POS.Aux
{
    public enum Comandos { Select, Insert,InsertDet, Update, Delete, SelectDt, DeleteDt,SelectCombo, SelectCombo2, SelectComboCol };
    public enum DocumentosRtf { Preliminar,Declinacion,Convenio,Final,Salvamento,Documentos,Actualizacion };
    public enum DocumentosRtfServer 
    {
        Actualizacion0=1,
        convenio0=2,
        convenio1=3,
        convenio2=4,
        convenio3=5,
        Declinacion0=6,
        Declinacion1=7,
        Declinacion2=8,
        Declinacion3=9,
        final0=10,
        final1=11,
        InformePreeliminar=12,
        Preeliminar0=13,
        Preeliminar1=14,
        ProyectoDeclinacion0=15,
        Salvamento0=16,
        SolicitudDocumentos0=17
    }
    public class AccessConeccion
    {
        public  MySqlConnection coneccion;
        public string ConeccionString;
        private float iva;

        public AccessConeccion()
        {
            //Database ={ 4};
            ConeccionString = String.Format("Server={0};Port={1};" +
                                "User id={2};Password={3};Database={4};AllowLoadLocalInfile=True;",
                                "74.208.33.184", "3306", "nanocode",
                                "Hfj!gWcSqxog@0@&","nanoclean");
            coneccion = new MySqlConnection(ConeccionString);
        }
        private bool AbrirConeccion()
        {
            try
            {
                coneccion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper());
                return false;
            }
            return true;
        }
        public bool CerrarConeccion()
        {
            try
            {
                coneccion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper());
                return false;
            }
            return true;
        }
        public DataTable ObtieneTabla(string Comando)
        {
            DataTable value;
            value = new DataTable();
            MySqlDataAdapter da;

            try
            {
                da = new MySqlDataAdapter(Comando, coneccion);
                da.Fill(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper());
            }

            return value;
        }
        public DataRow GetFirstRow(string Comando)
        {
            DataTable dt = ObtieneTabla(Comando);
            if (dt == null)
                return null;
            DataRow r;
            try
            {
                r = dt.Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos");
                return null;
            }
            return r;
        }

        public Object ExecutaEscalar(string Comando)
        {
            Object value;
            MySqlCommand cmd;
            value = null;
            try
            {
                if (!AbrirConeccion())
                    return value;
                cmd = new MySqlCommand(Comando, coneccion);
                value = cmd.ExecuteScalar();
                if (value == null)
                    value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper());
                value = null;
            }
            finally
            {
                CerrarConeccion();
            }

            return value;
        }
        public Object ExecutaEscalar(string Comando,string[] ParStr,Object[] Parametros)
        {
            Object value;
            MySqlCommand cmd;
            value = null;
            try
            {
                if (!AbrirConeccion())
                    return value;
                cmd = new MySqlCommand(Comando, coneccion);
                for (int i=0;i<ParStr.Length;i++)
                {
                    cmd.Parameters.AddWithValue(ParStr[i], Parametros[i]);
                }
                value = cmd.ExecuteScalar();
                if (value == null)
                    value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper());
                value = null;
            }
            finally
            {
                CerrarConeccion();
            }

            return value;
        }

        public string ToFecha(DateTime _Fecha)
        {
            string fecha = "NULL";
            DateTime f = _Fecha;
            string m = '0' + f.Month.ToString(); ;
            string d = '0' + f.Day.ToString();
            string h = '0' + f.Hour.ToString();
            string mm = '0' + f.Minute.ToString();

            m = m.Substring(m.Length - 2);
            d = d.Substring(d.Length - 2);
            h = h.Substring(h.Length - 2);
            mm = mm.Substring(mm.Length - 2);

            

            if (_Fecha != null && _Fecha != DateTime.MinValue)
            {
                //fecha = "CONVERT(DATETIME,'" + f.Year+ "-" + f.Month + "-" + f.Day  + " " + f.Hour + ":" + f.Minute + "',102)";

                //fecha = "CAST('" + f.Year + "-" + f.Month + "-" + f.Day + " " + f.Hour + ":" + f.Minute + ":00 AS DATETIME)";
                fecha = "CAST('"+ f.Year + "-" + f.Month + "-" + f.Day + " " + f.Hour + ":" + f.Minute + ":00' AS DATETIME)";
            }
            return fecha;
        }
        public string ToFecha(DevExpress.XtraEditors.DateEdit _Fecha)
        {
            string fecha = "NULL";
            if (null==_Fecha.EditValue || ((int)0001==_Fecha.DateTime.Year))
            {
                return fecha;
            }
            DateTime f = (DateTime)_Fecha.EditValue;
            string m = '0' + f.Month.ToString(); ;
            string d = '0' + f.Day.ToString();
            string h = '0' + f.Hour.ToString();
            string mm = '0' + f.Minute.ToString();

            m = m.Substring(m.Length - 2);
            d = d.Substring(d.Length - 2);
            h = h.Substring(h.Length - 2);
            mm = mm.Substring(mm.Length - 2);



            if (_Fecha != null )//&& _Fecha != DateTime.MinValue)
            {
                fecha = "CONVERT(DATETIME," + f.Year + "-" + f.Month + "-" + f.Day + " " + f.Hour + ":" + f.Minute + ":00)";
            }
            return fecha;
        }
        public float  Iva
        {
            get
            {
                string ObtieneIva = "SELECT Iva FROM ve_Iva";
                string aux = "";
                aux = ExecutaEscalar(ObtieneIva).ToString();
                iva = 0;
                aux = aux.Replace(",", ".");
                float.TryParse(aux, out iva);
                return iva;
            }
            set
            {
                string NuevoIva = "INSERT INTO ct_Iva (Iva, Fecha) VALUES (" + value + ", " + ToFecha(DateTime.Today) + ")";
                ExecutaEscalar(NuevoIva);
            }
        }

        public MySqlDataReader GetDataReader(string Comando)// TODA VEZ QUE SE OBTIENE UN DATA READER SE MANTIENE LA CONECCION ABIERTA DEBE CERRARSE
        {
            MySqlDataReader dr;
            MySqlCommand cmd;
            dr = null;
            try
            {
                AbrirConeccion();
                cmd = new MySqlCommand(Comando, coneccion);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToUpper());
            }
            return dr;
        }
        public void ActualizaTabla(string cmdSelect, DataTable Tabla)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSelect, coneccion);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.Update(Tabla);
        }

        public int GetBool(CheckBox cb)
        {
            int aux;
            aux = cb.Checked ? 1 : 0;
            return aux;
        }
        public int GetBool(RadioButton  cb)
        {
            int aux;
            aux = cb.Checked ? 1 : 0;
            return aux;
        }

		public bool ValidaExistencia(string Tabla, string Campo, string Value)
        {
            bool existe = false;
            string cmd = "SELECT Count(`" + Campo + "`) FROM " + Tabla + " WHERE (`" + Campo + "` ='" + Value + "')";
            if (Int32.Parse(ExecutaEscalar(cmd).ToString()) > 0)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            return existe;
        }
        public byte[] GetDocumentByetsFromBD(DocumentosRtfServer Doc)
        {
            byte[] docBytes;
            int ID = (int)Doc;
            string cmd = "SELECT Rtf FROM RtfDocs WHERE ID=" + ID + "";
            docBytes = (byte[])ExecutaEscalar(cmd);
            return docBytes;
        }
    }
}

