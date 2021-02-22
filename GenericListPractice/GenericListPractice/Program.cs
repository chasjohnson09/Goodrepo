using System;
using System.Collections.Generic;

namespace GenericListPractice
{
    class Program       // check class notes under generic collection for what the instructions were
    {
        static void Main(string[] args)
        {   /*
            var friends = new List<Friend>();       // this is showing how to set p a list 

            var bob = new Friend { Name = "Bob", Email = "Bob123@yahoo.com", BFF = true };  //inseting friends into the new list
            friends.Add(bob);
            var frank = new Friend { Name = "Frank", Email = "frank534@gmail.com", BFF = false };
            friends.Add(frank);
            var pam = new Friend { Name = "Pam", Email = "pam83949@yhoo.com", BFF = true };
            friends.Add(pam);

            foreach(var friend in friends)      // for each of the friends in Friends
            {
                Console.WriteLine($"{friend.Name}");    // write out the name 
            } */

            var friends = new Dictionary<long, Friend>();       // setting up a new dictionary 
            var bob = new Friend { Name = "Bob", Email = "Bob123@yahoo.com", BFF = true, PhoneNumber = 5139482749 };    // inserting new friend 
            friends.Add(bob.PhoneNumber, bob);
            var frank = new Friend { Name = "Frank", Email = "frank534@gmail.com", BFF = false, PhoneNumber = 5138571957 };
            friends.Add(frank.PhoneNumber, frank);
            var pam = new Friend { Name = "Pam", Email = "pam83949@yhoo.com", BFF = true, PhoneNumber = 5139572847 };
            friends.Add(pam.PhoneNumber, pam);
            foreach (var phone in friends.Keys)     // for each of the friends in friends 
            {
                var friend = friends[phone];
                Console.WriteLine($"{friend.PhoneNumber} : {friend.Name}"); // write out the phone number and the name for each 
            }

        }
    }

    internal class Dictionary<T>
    {
        public Dictionary()
        {
        }
    }
}
