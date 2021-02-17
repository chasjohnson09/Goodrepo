using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class SavingsComposition
    {
        public decimal Interestrate { get; set; } = 0.12m;  // double looks the same but the "M" makes the program treat it like a decimal

        public Account account { get; set; }    // creating instance of the account class
 
        public decimal Balance
        {
            get { return account.Balance; }
        }

        public void Deposit(decimal amount)
        {
            account.Deposit(amount);    // no need for "return" becuase void is there
        }
        public void Withdraw(decimal amount)
        {
            account.Withdraw(amount);    // no need for "return" becuase void is there
        }
        public SavingsComposition() {
            this.account = new Account("4", "Savings Account");
        }
        public decimal Interest(int months)
        {
            return account.Balance * (Interestrate / 12) * months;
        }
        public void PayInterest(int months)
        {
            var interest = Interest(months);
            Deposit(interest);
        }
    }
}
