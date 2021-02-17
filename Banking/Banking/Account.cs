using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account   // setting properties of the class
    {
        public string Accountnumber { get; private set; }  // the various types of properties --- private before set also lets other classes read but not write
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal amount)     // setting up deposit statement
        {
           if(amount > 0)   // not letting the ammount be under 0
            {
            Balance += amount;  // statement to be executed 
            }
        }
        
       
        public void Withdraw(decimal amount)    // setting up withdraw statement 
        {
            if(amount < 0)  // not letting the ammount be under 0
            {
                return;
            }
            if(Balance >= amount) // if the ammount is greater than the balance let the statement happen
            {
                Balance -= amount;  //statement to execute
            }
            else
            {
                Console.WriteLine($"Insufficient funds");
            }
            

        }

       // public Account() : this("Defacct0  { }
        public Account(string acctNbr, string desc = "New Acoount")
        {
            Accountnumber = acctNbr;
            Description = desc;
        }
    }
}
