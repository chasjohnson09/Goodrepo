using System;

namespace SchoolWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var jadacapstone = new Capstone
            { Attempts = 1, DateOfCertification = new DateTime(2020, 8, 15), Score = 100 };
            var jadaGit = new Assessment
            {
                Topic = "Git",
                DateOfAssessment = new DateTime(2020, 6, 15),
                Score = 120
            };
            var JadaSql = new Assessment
            {
                Topic = "SQL",
                DateOfAssessment = new DateTime(2020, 7, 5),
                Score = 110
            };
            var jada = new IPrintable[] { jadacapstone, jadaGit, JadaSql };
            foreach (var item in jada)
            {
                item.Print();
            }
            Console.WriteLine($"");

            var chascapstone = new Capstone
            {
                Score = 100,
                Attempts = 2,
                DateOfCertification = new DateTime(2021, 4, 16)
            };
            var chassql = new Assessment
            {
                Topic = "Sql",
                DateOfAssessment = new DateTime(2021, 2, 19),
                Score = 100
            };
            var chasgit = new Assessment
            {
                Topic = "GIT",
                Score = 100,
                DateOfAssessment = new DateTime(2021, 2, 10)
            };
            var chas = new IPrintable[] { chascapstone, chassql, chasgit };
            foreach (var item in chas)
            {
                item.Print();
            }
        }
    }
}
