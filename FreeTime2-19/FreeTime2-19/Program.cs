using System;

namespace FreeTime2_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var idx = 1; idx <= 30; idx++)
            {
                if (idx % 3 == 0 && idx % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else
                {
                    if (idx % 5 == 0)
                    {
                        Console.WriteLine("BUZZ");
                    }
                    else
                    {
                        if (idx % 3 == 0)
                        {
                            Console.WriteLine("FIZZ");
                        }
                        else
                        {
                            Console.WriteLine($" {idx} ");
                        }
                    }
                }
            }


        }
    }
}
