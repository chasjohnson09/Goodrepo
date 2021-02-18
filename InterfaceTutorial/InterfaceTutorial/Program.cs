using System;

namespace InterfaceTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var gs = new GermanShepard();
            gs.SetName("Sargent");
            var pg = new Pug();
            pg.SetName("Walter");
            var bh = new BassetHound();
            bh.SetName("Charlie");
            var dp = new DogParrot();
            dp.SetName("Polly");

            var dogs = new IBarkable[]  // setting the aray
            {
                gs, pg, bh, dp
            };
            foreach(var dog in dogs)    // for each of the idx do below
            {
                Console.WriteLine($"The dog {dog.GetName()} sounds like {dog.Bark()}");
            }
        }
    }
}
