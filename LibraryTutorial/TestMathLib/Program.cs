using System;
using LibraryTutorial;      // connecctig the program to the library

namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathlib = new MathLib();        // showing the connection between program and class
            Console.WriteLine($"12 + 3 = {mathlib.Add(12,3)}");
            Console.WriteLine($"12 - 3 = {mathlib.Subtract(12, 3)}");
            Console.WriteLine($"12 * 3 = {mathlib.Multiply(12, 3)}");
            Console.WriteLine($"12 / 3 = {mathlib.Divide(12, 3)}");
            Console.WriteLine($"12 % 3 = {mathlib.Modulo(12, 3)}");
            Console.WriteLine($"12 ^ 3 = {mathlib.Power(12, 3)}");
            Console.WriteLine($"About is {mathlib.About}");
        }
    }
}
