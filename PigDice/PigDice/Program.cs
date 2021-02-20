using System;

namespace PigDice
{
    class Program
    {
        static int RollDie()
        {
            var rnd = new Random();     // setting up new random variable
            return rnd.Next(1, 7);      // give back a random number into rnd with parameters of 1,7
        }
        static int PlayPigDice()        //starting the loop of playing pigdice
        {
            var score = 0;
            var roll = RollDie();
            while(roll != 1)        // run until the number one is rolled
            {
                score += roll;      // if the number is not one then add the number to the score
                roll = RollDie();   // rerun the rolldie after the score has been added
            }
            return score;           // if the number rolled is 1 then return
        }

        static void Main(string[] args)
        {
            var HighScore = 300;        // the high score we want 
            
            long Counter = 0;           // building the counter for how many games it took to get to the high score
            var score = PlayPigDice();  // method for how the play pig dice 

            while(score < HighScore)    // setting it up so that way it will run until the game reaches the requested high score
            {
                score = PlayPigDice();  //every time the game is ran add one to the counter
                Counter++;
            }
            Console.WriteLine($"High Score is {score} in {Counter} games"); // we reached the high score wanted in x amount of games


        }
    }
}
