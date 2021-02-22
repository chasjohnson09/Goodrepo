using System;
using LibraryTutorial;

namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathlib = new MathLib();
            Console.WriteLine($"About is {mathlib.About}");
        }
    }
}
