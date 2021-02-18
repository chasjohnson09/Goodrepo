using System;

namespace ExceptionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try         // try to do below
            {
            Level1(3);
            }
            catch(Exception ex) // if there is an exception encountered, do below
            {
                Console.WriteLine("The program encountered an exception");
                Console.WriteLine($"Exception: {ex.Message}");      // "Message" is the default message set inside of the exception
            }
            Console.WriteLine("Done...");
        }
        static void Level1(int i)
        {
            Level2(i - 1);
        }
        static void Level2(int i) 
        {
            Level3(i - 2);
        }
        static void Level3(int i) 
        {
            var result = 100 / i;
            Console.WriteLine($" result is {result}");
            
        }
    }
}
