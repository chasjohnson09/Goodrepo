using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQL
{
    public class MajorsController
    {
        private Connection connection { get; set; }

        public bool RemoveRange(params int[] ids)
        {
            var success = true;
            foreach(var id in ids)
            {
                success &= Remove(id);
            }
            return success;
        }
        public bool Remove(int id)
        {
            var sql = $"Delete From Student Where Id = @id;";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            cmd.Parameters.AddWithValue("@id", id);
            var recsAffected = cmd.ExecuteNonQuery();
            return (recsAffected == 1);
        }

        public bool Change(Major majors)
        {
            var sql = $"Update Major Set Code = @code, Description = @description, MinSAT = @minSAT, where Id = @id;";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            cmd.Parameters.AddWithValue("@code", majors.Code);
            cmd.Parameters.AddWithValue("@decription", majors.Desrciption);
            cmd.Parameters.AddWithValue("@minsat", majors.MinSAT);
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);
        }

        public bool Create(Major major)
        {
            var sql = $"Insert into Major (Code, Description, MinSAT) VALUES('{major.Code}', '{major.Desrciption}', '{major.MinSAT}');";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);
        }
        public Major GetbyPK(int id)
        {
            var sql = $"Select * from Major where id = {id};";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            var reader = cmd.ExecuteNonQuery();
            var hasRow = reader.Read();
            if (!hasRow)
            {
                return null;
            }
            var major = new Major();
            major.Code = Convert.ToString(reader["Code"]);
            major.Desrciption = Convert.ToString(reader["Description"]);
        }

        public MajorsController (Connection connection)   
        {
            this.connection = connection;
        }
    }
}
