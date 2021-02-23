using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQL
{
    public class Connection // have to put public so hat way it can be accessed 
    {
        public SqlConnection connection { get; set; }

        public void Connect(string database)        // setting the connection
        {
            var connStr = $"server=localhost\\sqlexpress;" +
                            $"database={database};" +
                            $"trusted_connection=true;";
            connection = new SqlConnection(connStr);
            connection.Open();      // opening the connection
            if(connection.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection did not open");
            }

        }

        public void Disconnect()
        {
            connection.Close();
        }
    }
}
