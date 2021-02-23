using System;
using Microsoft.Data.SqlClient;
namespace CSharp2SQL
{
    public class EducDbLib
    {
        public  SqlConnection connection { get; set; }      // how to connect to sql database from vs
        
        public void SelectAllStudents()
        {
            var sql = "SELECT * From Student;";
            var cmd = new SqlConnection(sql, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id =Convert.ToInt32(reader["Id"]);
                var lastname = reader["Lastname"].ToString();
                Console.WriteLine($"Id = {id}, lastname = {lastname}");
            }
            reader.Close();
        }
        public void SelectAllMajors()
        {
            var sql2 = "SELECT * From Major;";
            var cmd2 = new SqlCommand(sql2, connection);
            var reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                var id2 = Convert.ToInt32(reader2["Id"]);
                var major = reader2["Major"].ToString();
                Console.WriteLine($"Id = {id2}, major = {major}");
            }
            reader2.Close();
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
