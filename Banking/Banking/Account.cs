using System;
using System.Collections.Generic;
using System.Text;
using Banking.Exceptions;

namespace Banking
{
    class Account   // setting properties of the class
    {
        public string Accountnumber { get; private set; }  // the various types of properties --- private before set also lets other classes read but not write
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal amount)     // setting up deposit statement
        {
           if(amount <= 0)   // not letting the ammount be under 0
            {
                throw new AmountMustBePositiveException();
            }
            else
            {
            Balance += amount;  // statement to be executed 
            }
        }
        
       
        public void Withdraw(decimal amount)    // setting up withdraw statement 
        {
            if(amount <= 0)  // not letting the ammount be under 0
            {
                throw new AmountMustBePositiveException();
            }
            if(Balance >= amount) // if the ammount is greater than the balance let the statement happen
            {
                Balance -= amount;  //statement to execute
            }
            else
            {
                throw new InsuffiecientFundsException(Balance, amount);
            }
            

        }

        public Account() : this("Defacct0", "Default Account Name") { } // defalt constructor
        public Account(string acctNbr, string desc = "New Account") // constructor with two parameters
        {
            Accountnumber = acctNbr;
            Description = desc;
        }
    }
}
