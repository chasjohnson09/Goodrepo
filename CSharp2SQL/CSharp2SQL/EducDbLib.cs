using System;
using Microsoft.Data.SqlClient;
namespace CSharp2SQL
{
    public class EducDbLib
    {
        public  SqlConnection connection { get; set; }
        

        public void Connect(string database)
        {
            var connStr = $"localhost\\sqlexpress;" +
                            $"database={database};" +
                            "trusted_connection=true;";
            connection = new SqlConnection(connStr);
            connection.Open();
        }
        
    }
}
