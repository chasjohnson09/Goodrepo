using CSharp2SQL;
using System;
namespace TestCSharp2SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new Connection();
            conn.Connect("EdDb");
            Console.WriteLine("Connection was succesful!");

            var studentController = new StudentsController(conn);       // using the sql connection in the controller to use the same connection for the class

            var newStudent = new Student
            {
                Id = 0,
                Firstname = "Joesph",
                Lastname = "Biden",
                Statecode = "DC",
                SAT = 1300,
                GPA = 3.2m,
                Major = null
            };
            //var success = studentController.Create(newStudent);

            newStudent.Id = 63;
            var success = studentController.Change(newStudent);

            var student = studentController.GetbyPK(54);
            Console.WriteLine($"{student.Id} {student.Firstname} {student.Lastname}");

            success = studentController.Remove(61);
            Console.WriteLine($"Remove worked? {success}");

            success = studentController.RemoveRange(62, 63, 64, 65);

            //var students = studentController.GetAll();
            //foreach( var s in students)
            //{
            //    Console.WriteLine($"{s.Id} {s.Firstname} {s.Lastname} | {s.Major}");
            //}


            conn.Disconnect();
            Console.WriteLine("Discconect was succesful!");

           // var sql = new EducDbLib();
           //// var sql2 = new EducDbLib();
           // sql.Connect("EdDb");
           // Console.WriteLine("Connected successfully!");

           // //sql.SelectAllStudents();
           // //sql2.SelectAllMajors();
           // sql.SelectAllClasses();
           // sql.Disconnect();
           // Console.WriteLine("Disconnected successfully!");
        }
    }
}
