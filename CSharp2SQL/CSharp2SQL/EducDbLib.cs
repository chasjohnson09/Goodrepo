using System;
using Microsoft.Data.SqlClient;
namespace CSharp2SQL
{
    public class EducDbLib
    {
        public  SqlConnection connection { get; set; }      // how to connect to sql database from vs
        
        public void SelectAllClasses()
        {
            var sql = "Select * from Class;";
            var cmd = new SqlCommand(sql, connection);
            var reader3 = cmd.ExecuteReader();
            while (reader3.Read())
            {
                var id = Convert.ToInt32(reader3["Id"]);
                var code = reader3["Code"].ToString();
                var subject = reader3["Subject"].ToString();
                var section = reader3["Section"].ToString();
                Console.WriteLine($"Id = {id}, code = {code}, Subject = {subject}, Section = {section}");
            }
        }
        public void Connect(string database)        // setting the connection 
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
