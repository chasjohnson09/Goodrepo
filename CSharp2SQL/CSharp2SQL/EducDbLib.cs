using System;
using Microsoft.Data.SqlClient;
namespace CSharp2SQL
{
    public class EducDbLib
    {
        public  SqlConnection connection { get; set; }      // how to connect to sql database from vs
        

        public void Connect(string database)
        {
            var connStr = $"server=localhost\\sqlexpress;" +
                            $"database={database};" +
                            "trusted_connection=true;";
            connection = new SqlConnection(connStr);
            connection.Open();
            if(connection.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection is not open!");
            }
            
        }
        public void Disconnect()
        {
            connection.Close();
        }
    }
}
