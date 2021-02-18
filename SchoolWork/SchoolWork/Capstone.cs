using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolWork
{
    class Capstone : IPrintable     // ": IPrintable" connects the class to the interface "IPrintable"
    {
        public DateTime DateOfCertification { get; set; } 
        public int Attempts { get; set; }
        public int Score { get; set; }
        public void Print()     //method that links to the interface
        {
            var msg = $"CAPSTONE: score:{Score}, on attempt:{Attempts} {DateOfCertification}";
            Console.WriteLine(msg);
        }
        public int GetScore()
        {
            return Score;
        }
    }
}
