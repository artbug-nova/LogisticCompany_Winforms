using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Store
{
    public static class SQLConnection
    {
        private static SqlConnection sqlConnection = null;
        private static String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database\\store.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectionString);
            }
            if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
            return sqlConnection;
        }
    }
}
