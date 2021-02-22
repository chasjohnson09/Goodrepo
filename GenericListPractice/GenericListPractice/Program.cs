using System;
using System.Collections.Generic;

namespace GenericListPractice
{
    class Program       // check class notes under generic collection for what the instructions were
    {
        static void Main(string[] args)
        {
            var friends = new List<Friend>();

            var bob = new Friend { Name = "Bob", Email = "Bob123@yahoo.com", BFF = true };
            friends.Add(bob);
            var frank = new Friend { Name = "Frank", Email = "frank534@gmail.com", BFF = false };
            friends.Add(frank);
            var pam = new Friend { Name = "Pam", Email = "pam83949@yhoo.com", BFF = true };
            friends.Add(pam);

            foreach(var friend in friends)
            {
                Console.WriteLine($"{friend.Name}");
            }
            
        }
    }
}
