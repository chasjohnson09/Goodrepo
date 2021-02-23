using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQL
{
    public class StudentsController
    {
        private Connection connection { get; set; }      // taking the connection from the instance to make the connection for this class

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
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);

        }
        public bool Change(Student student)
        {
            var sql = $"Update Student Set" +
                        " Firstname = @firstname," +
                        " Lastname = @lastname," +
                        " StateCode = @statecode," +
                        " SAT = @sat," +
                        " GPA = @gpa" +
                        " Where Id = @id;";

            var cmd = new SqlCommand(sql, connection.sqlconnection);
            cmd.Parameters.AddWithValue("@firstname", student.Firstname);
            cmd.Parameters.AddWithValue("@lastname", student.Lastname);
            cmd.Parameters.AddWithValue("@statecode", student.Statecode);
            cmd.Parameters.AddWithValue("@sat", student.SAT);
            cmd.Parameters.AddWithValue("@gpa", student.GPA);
            cmd.Parameters.AddWithValue("@id", student.Id);
            var recsAffects = cmd.ExecuteNonQuery();
            return (recsAffects == 1);
        }
        public bool Create(Student student)             // adding a student to the database from vs
        {
            var sql = $"Insert into Student (Firstname, Lastname, Statecode, SAT, GPA)" +           // filling all properites that are required to create the new student
                $" VALUES('{student.Firstname}', '{student.Lastname}', '{student.Statecode}'," +
                $" '{student.SAT}', '{student.GPA}');";
            var cmd = new SqlCommand(sql, connection.sqlconnection);
            var rowsAffected = cmd.ExecuteNonQuery();
            return (rowsAffected == 1);     // if the rows affected = 1 then the statement is true
        }
        public Student GetbyPK(int id)      //getting the primary key and pulling all the rows in it 
        {
            var sql = $"Select * from Student where id = {id};";
            var cmd = new SqlCommand(sql, connection.sqlconnection);    // property inside of the collection class
            var reader = cmd.ExecuteReader();
            var hasRow = reader.Read();
            if (!hasRow)                // this gets rid of the empty rows inside of the data and turns it to null 
            {
                return null;
            }
            var student = new Student();
            student.Id = Convert.ToInt32(reader["Id"]);
            student.Firstname = Convert.ToString(reader["Firstname"]);  //converting all of the values to their proper type
            student.Lastname = Convert.ToString(reader["Lastname"]);
            student.Statecode = Convert.ToString(reader["StateCode"]);
            student.SAT = Convert.ToInt32(reader["SAT"]);
            student.GPA = Convert.ToDecimal(reader["GPA"]);

            //student.Major = null;                                     //sets the major to null 
            //if (reader["Description"] != System.DBNull.Value)                // if the majorid is not null then the Description will be pushed into the value
            //{
            //    student.Major = reader["Description"].ToString();
            //}
            reader.Close();
            return student;
        } 
        public List<Student> GetAll()
        {
            var sql = "Select * from Student s left join Major m on s.MajorId = m.Id order by s.Lastname;";
            var cmd = new SqlCommand(sql, connection.sqlconnection);    // property inside of the collection class
            var reader = cmd.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read())
            {
                var student = new Student();
                student.Id = Convert.ToInt32(reader["Id"]);
                student.Firstname = Convert.ToString(reader["Firstname"]);  //converting all of the values to their proper type
                student.Lastname = Convert.ToString(reader["Lastname"]);
                student.Statecode = Convert.ToString(reader["StateCode"]);
                student.SAT = Convert.ToInt32(reader["SAT"]);
                student.GPA = Convert.ToDecimal(reader["GPA"]);

                //student.Major = null;                                     //sets the major to null 
                //if(reader["Description"] != System.DBNull.Value)                // if the majorid is not null then the Description will be pushed into the value
                //{
                //    student.Major = reader["Description"].ToString();
                //}
                
                //students.Add(student);      // add the student to the list

            }
            reader.Close();
            return students;
        }

        public StudentsController(Connection connection)    // creating an instance using one parameter-- which is the connection
        {
            this.connection = connection;
        }
    }
}
