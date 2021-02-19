using System;
using System.Collections.Generic;

namespace GenericCollectionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var WXHistory = new List<Weather>(3);    // creating a new variable and list using the weather class
            var DtThursday = new Weather       // creating a new day in WXWeather
            {
                Today = new DateTime(2021, 2, 18),  // properties that were set inside the weather class
                Temp = 19,
                Percipitation = 3
            };
            WXHistory.Add(DtThursday);
            var DtWednesday = new Weather
            {
                Today = new DateTime(2021, 2, 17),
                Temp = 4,
                Percipitation = 0
            };
            WXHistory.Add(DtWednesday);
            var DtTuesday = new Weather
            {
                Today = new DateTime(2021, 2, 16),
                Temp = 25,
                Percipitation = 2
            };
            WXHistory.Add(DtTuesday);

            foreach( var day in WXHistory)
            {
                var msg = $"Weahter for {day.Today.ToString("MMM,dd,yyyy")}--" +    // setting the var msg to write out what we want
                    $" Percipitation was {day.Percipitation} inches, Temp was {day.Temp} degrees";
                Console.WriteLine(msg); // executing each write line for each of the days
            }
            
            var Strng = new List<string>    //creating a new list based on color 
            {
                "orange","blue","gray","red","black", "green"
            };
            Console.WriteLine($"Favorite color count is {Strng.Count}");    //how many items are actually in the list 
            
            
            Strng.Sort();   // sort the list Strng 
            foreach(var color in Strng) // for each of the colors in the list
            {
                Console.WriteLine($" color is {color}");
            }
            
            var Ints = new List<int>(); //creating a new list for favorite number
            Ints.Add(7);
            Ints.Add(10);
            Ints.Add(3);
            Ints.Add(6);
            Ints.Add(96);
            Ints.Add(22);

            foreach(var i in Ints)  // foreach of the variables in Ints 
            {
                Console.WriteLine($" number is {i}");   // write out the number
            }
        }
    }
}
