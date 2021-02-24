using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQL
{
    public class ClassController
    {
        private Connection connection { get; set; }

        public bool RemoveRange(params int[] ids)
        {
            var success = true;
            foreach (var id in ids)
            {
                success &= Remove(id);
            }
            return success;
        }
        public bool Remove(int id)
        {
            var sql = $"Delete from Class Where Id = @id;";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            cmd.Parameters.AddWithValue("id", id);
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);
        }
        public bool Change(Class2021 class2021)
        {
            var sql = $"Update Class Set Code = @code, Subject = @subject, Section = @section;";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            cmd.Parameters.AddWithValue("@code", class2021.Code);
            cmd.Parameters.AddWithValue("@subject", class2021.Subject);
            cmd.Parameters.AddWithValue("@section", class2021.Section);
            cmd.Parameters.AddWithValue("@instructorid", class2021.InstructorId);
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);
        }
        public bool Create(Class2021 class2021)
        {
            var sql = $"Insert into Major (Code, Subject, Section) Values('{class2021.Code}', '{class2021.Subject}', '{class2021.Section}');";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);
        }
        public Class2021 GetbyPK(int id)
        {
            var sql = $"Select * from Class where id = {id};";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            var reader = cmd.ExecuteReader();
            var hasrows = reader.Read();
            if (!hasrows)
            {
                return null;
            }
            var klass = new Class2021();
            klass.Id = Convert.ToInt32(reader["Id"]);
            klass.Code = Convert.ToString(reader["Code"]);
            klass.Subject = Convert.ToString(reader["Subject"]);
            klass.Section = Convert.ToInt32(reader["Section"]);
            klass.InstructorId = Convert.ToInt32(reader["InstructorId"]);
            reader.Close();
            return klass;

        }
        public List<Class2021> GetAll()
        {
            var sql = $"Select * from Class c join Instructor i on c.InstructorId = i.Id;";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            var reader = cmd.ExecuteReader();
            var klasses = new List<Class2021>();
            while (reader.Read())
            {
                var klass = new Class2021();
                klass.Id = Convert.ToInt32(reader["Id"]);
                klass.Code = Convert.ToString(reader["Code"]);
                klass.Subject = Convert.ToString(reader["Subject"]);
                klass.Section = Convert.ToInt32(reader["Section"]);
                klass.InstructorId = Convert.ToInt32(reader["InstructorId"]);
            }
            reader.Close();
            return klasses;
        }
            public ClassController(Connection connection)
            {
                this.connection = connection;
            }
    }
}