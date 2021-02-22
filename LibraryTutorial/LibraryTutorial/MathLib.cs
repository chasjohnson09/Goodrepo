using System;

namespace LibraryTutorial
{
    public class MathLib
    {
        public string About { get; set; } = "About MathLib";        // setting the property for the library 
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Modulo(int a, int b)
        {
            return a - (a / b * b);
        }
        public int Power(int a, int b)
        {
            var answer = 1;
            for(int idx = 0; idx < b; idx++)
            {
                answer *= a;
            }
            return answer;
        }

        
    }
}
