using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace MyFood
{
    class DB
    {
        public static string DBFile = "MyFood.accdb";
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="  + Application.StartupPath + @"\MyFood.accdb;Jet OLEDB:Database Password=123");
        public static OleDbCommand cmd = new OleDbCommand("", conn);
        
        public static void Open()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public static void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public static DataTable GetDate(string SQLstatment)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = SQLstatment;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }

        public static void Run(string SQLstatment)
        {
            cmd.CommandText = SQLstatment;
            cmd.ExecuteNonQuery();
        }

    }
}
