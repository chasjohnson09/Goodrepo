using CSharp2SQL;
using System;
namespace TestCSharp2SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new EducDbLib();
            sql.Connect("EdDb");
            Console.WriteLine("Connected successfully!");

            sql.ExecSelect();
            
            sql.Disconnect();
            Console.WriteLine("Disconnected successfully!");
        }
    }
}
