using System;
using System.Collections.Generic;

namespace Bowling
{
    class Program
    {
        static int Bowl1Game(Random rnd)       // setting up "Bowl1Game" method so it can e called upon inside the main method
        {
            var Game = new List<int>(10);           // creating the list

            for(var idx = 0; idx < 10; idx++)     // generating the array for the 10 frames
            {
                var score = rnd.Next(0, 31);     // random number generator for numbers 0-30
                Game.Add(score);                // add the score to the game
            }
            var total = 0;                       // creating a variable for total 
            foreach(var score in Game)          // for each of the scores in the game 
            {
                total += score;                  // adding the score from each frame to get a total score
            }
            Console.WriteLine($"Bowling score total is {total} ");
            return total;                        // return the total 
        }
        static void Main(string[] args)

        {
            var rnd = new Random();
            var Series = 0;                     //setting a variable to e able to have a series score
            for(var idx = 0; idx < 3; idx++)        //creating an array to create three games
            {

                var score = Bowl1Game(rnd);     // call upon the "Bowl1Game" method 
                Series += score;                // add the score of the game to the series score
            }
            Console.WriteLine($"Series score is {Series}");     //print the series total 
        }
    }
}
