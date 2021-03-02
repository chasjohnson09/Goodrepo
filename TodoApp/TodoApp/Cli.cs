using System;
using System.Collections.Generic;
using System.Text;
using ToDoLib.Models;

namespace TodoApp
{
    public class Cli
    {
        public static void DisplayLine(string prompt)
        {
            Console.WriteLine($"{prompt}");
        }
        public static CreateTodo(string prompt)
        {
            var todo = new Todo()
            {
                Id = 0,
                Description = Convert.ToString.

            }

        }
        public static DateTime? GetDateTime(string prompt)
        {
            var response = Getstring(prompt);
            if(response.Length == 0)
            {
                return null;
            }
            return Convert.ToDateTime(response);
        }
        public static int Getint(string prompt)
        {
            var response = Getstring(prompt);
            return Convert.ToInt32(response);
        }
        public static string Getstring(string prompt)
        {
            Console.Write($"{prompt}: ");   // this is the prompt setup
            var response = Console.ReadLine();  // this is so the user can enter in data and hit enter
            return response;
        }
    }
}
