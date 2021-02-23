using CSharp2SQL;
using System;
namespace TestCSharp2SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new EducDbLib();
            var sql2 = new EducDbLib();
            sql.Connect("EdDb");
            sql2.Connect("EdDb");
            Console.WriteLine("Connected successfully!");

            sql.SelectAllStudents();
            sql2.SelectAllMajors();
            
            sql.Disconnect();
            Console.WriteLine("Disconnected successfully!");
        }
    }
}
