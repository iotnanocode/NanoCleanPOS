using POS.Aux.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POS.Aux
{
    public class SQLiteAux
    {
        string DATA_BASE_PATH;      

        string STR_CONN;
        int FIRST_ROW_INDEX = 0;
        public SQLiteAux(string DB_PATH)
        {
            DATA_BASE_PATH = DB_PATH;
            STR_CONN = $"DATA Source={DATA_BASE_PATH};";
        }
        public DataTable GetDataTable(string str_COMMAND,List<CommandParameter> Parametros=null)
        {
            DataTable returnDt = null;
            SQLiteConnection liteConnection = new SQLiteConnection(STR_CONN);
            SQLiteCommand liteCommand = new SQLiteCommand(str_COMMAND, liteConnection);
            if (Parametros!=null)
            {
                /*el comando que se manda incluye parametros*/
                foreach (var item in Parametros)
                {
                    liteCommand.Parameters.AddWithValue(item.ParameterName, item.ParameterValue);
                }
            }
            else
            {
                /*do nothign*/
            }
            try
            {
                liteConnection.Open();
                var result = liteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    /*fill datatable only if has rows*/
                    returnDt = new DataTable();
                    returnDt.Load(result);
                }
                else
                {
                    /*do nothing*/
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                liteConnection.Close();
            }
            return returnDt;
        }
        public DataRow GetFirstRow(string str_COMMAND,List<CommandParameter> Parametros=null)
        {
            var result = GetDataTable(str_COMMAND,Parametros);
            DataRow returRow = null;
            if (result != null)
            {
                /*has rows*/
                returRow = result.Rows[FIRST_ROW_INDEX];
            }
            else
            {
                /*do nothing*/
            }
            return returRow;
        }
        public string GetSingleValue(string str_COMMAND, List<CommandParameter> Parametros = null)
        {
            var resultRow = GetFirstRow(str_COMMAND, Parametros);
            string resultValue;
            if (resultRow!=null)
            {
                resultValue = resultRow[0].ToString();
            }
            else
            {
                resultValue = "";
            }
            return resultValue;

        }
        public bool ExecuteScalar(string str_COMMAND,List<CommandParameter> Parametros=null)
        {
            bool hasResult = false;
            SQLiteConnection liteConnection = new SQLiteConnection(STR_CONN);
            SQLiteCommand liteCommand = new SQLiteCommand(str_COMMAND, liteConnection);

            if (Parametros != null)
            {
                /*el comando que se manda incluye parametros*/
                foreach (var item in Parametros)
                {
                    liteCommand.Parameters.AddWithValue(item.ParameterName, item.ParameterValue);
                }
            }
            else
            {
                /*do nothign*/
            }

            try
            {
                liteConnection.Open();
                var result = liteCommand.ExecuteNonQuery();
                hasResult = result > 0;
            }
            catch (Exception ex) { }
            finally
            {
                liteConnection.Close();
            }
            return hasResult;
        }
        public bool InsertaDataTable(DataTable dtToInsert,string TableName)
        {
            string cmd = $"INSERT INTO {TableName} (";
            foreach (DataColumn col in dtToInsert.Columns)
            {
                cmd += $"{col.ColumnName},";
            }
            /*remuevo la ultima coma*/
            cmd = cmd.Remove(cmd.Length - 1);
            cmd += ") ";
            /*genero el insert values*/
            cmd += $"VALUES (";
            foreach (DataRow item in dtToInsert.Rows)
            {
                foreach (DataColumn col in dtToInsert.Columns)
                {
                    cmd += $"'{item[col.ColumnName]}',";
                }
                /*remuevo la ultima coma*/
                cmd = cmd.Remove(cmd.Length - 1);
                cmd += "),(";
            }
            /*remuevo la ultima coma*/
            cmd = cmd.Remove(cmd.Length - 2);
            return ExecuteScalar(cmd);
        }
    }
}
