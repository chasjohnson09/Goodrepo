using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class SavingsInherate : Account
    {
        public decimal InterestRate { get; set; } = 0.12m;

        public void PayInterest(int months)
        {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }
        public SavingsInherate() 
            : base() { }
        public SavingsInherate(string AcctNbr, string Desc) 
            : base(AcctNbr, Desc)
        {

        }
        public SavingsInherate(string AcctNbr, decimal IntRate) 
            : base(AcctNbr, "New savings account") 
        {
            this.InterestRate = IntRate;
        }
    }
}
