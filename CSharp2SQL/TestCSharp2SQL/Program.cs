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
