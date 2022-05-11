using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
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
        public DataTable GetDataTable(string str_COMMAND)
        {
            DataTable returnDt = null;
            SQLiteConnection liteConnection = new SQLiteConnection(STR_CONN);
            SQLiteCommand liteCommand = new SQLiteCommand(str_COMMAND, liteConnection);
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
        public DataRow GetFirstRow(string str_COMMAND)
        {
            var result = GetDataTable(str_COMMAND);
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
        public bool ExecuteScalar(string str_COMMAND)
        {
            bool hasResult = false;
            SQLiteConnection liteConnection = new SQLiteConnection(STR_CONN);
            SQLiteCommand liteCommand = new SQLiteCommand(str_COMMAND, liteConnection);
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
    }
}
