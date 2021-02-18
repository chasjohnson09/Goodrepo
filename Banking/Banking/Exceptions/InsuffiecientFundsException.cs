using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions
{
    class InsuffiecientFundsException : Exception
    {
        public decimal AcctBalance { get; set; }
        public decimal AmounttoWithdraw { get; set; }

        public InsuffiecientFundsException(decimal balance, decimal amount)
            : base($"Current Balance is {balance}, withdraw amount is {amount}") 
        {
            AcctBalance = balance;
            AmounttoWithdraw = amount;
        }
        public InsuffiecientFundsException() 
            : base() { }
        public InsuffiecientFundsException(string Message) 
            : base(Message) { }
        public InsuffiecientFundsException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
