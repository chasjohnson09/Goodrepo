using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQL
{
    public class Connection // have to put public so that way it can be accessed 
    {
        public SqlConnection sqlconnection { get; set; }

        public void Connect(string database)        // setting the sqlconnection
        {
            var connStr = $"server=localhost\\sqlexpress;" +
                            $"database={database};" +
                            $"trusted_connection=true;";
            sqlconnection = new SqlConnection(connStr);
            sqlconnection.Open();      // opening the sqlconnection
            if(sqlconnection.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection did not open");
            }

        }

        public void Disconnect()
        {
            sqlconnection.Close();
        }
    }
}
