using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolWork
{
    class Assessment : IPrintable   // ": IPrintable" connects the class to the interface "IPrintable"
    {
        public string Topic { get; set; }
        public DateTime DateOfAssessment { get; set; } = DateTime.Now;  // "datetime.now" gets current date and time based on local time
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public void Print()
        {
            var msg = $"Assessment: score:{Score}, topic: {Topic} {DateOfAssessment}";
            Console.WriteLine(msg);
        }
        public int GetScore()
        {
            return Score;
        }

    }
}
