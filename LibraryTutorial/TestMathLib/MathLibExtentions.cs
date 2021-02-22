using System;
using System.Collections.Generic;
using System.Text;

namespace TestMathLib
{
    public static class MathLibExtentions   // since it is static all methods and properties must be static
    {
        public static void Print(this string s)
        {
            Console.WriteLine($"{s}");      //setting up a print method that can be called upon from the extension
        }
        public static int Squared(this int a)   // must have "this" to be called upon
        {
            return a * a;
        }
        public static int Cubed(this int a)     // must have "this" to be called upon
        {
            return a * a * a;
        }
        public static int Power(this int a, int b)  // must have "this" to be called upon
        {
            var answer = 1;
            for (var idx = 0; idx < b; idx++)
            {
                answer *= a;
            }
            return answer;
        }
    }
}
