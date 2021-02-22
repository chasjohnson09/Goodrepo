using System;
using System.Collections.Generic;
using System.Text;

namespace TestMathLib
{
    public static class MathLibExtentions   // since it is static all methods and properties must be static
    {
        public static int Squared(this int a)
        {
            return a * a;
        }
        public static int Cubed(this int a)
        {
            return a * a * a;
        }
        public static int Power(this int a, int b)
        {
            var answer = 1;
            for (var idx = 0; idx < b; idx++)
            {
                answer *= b;
            }
            return answer;
        }
    }
}
