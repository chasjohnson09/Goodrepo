using Banking.Exceptions;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav1 = new SavingsComposition();    // creating new savings account with SavingsComposition
            sav1.Deposit(50);
            Console.WriteLine($"Savings balance is {sav1.Balance}");
            sav1.Withdraw(20);
            Console.WriteLine($"Savings balance is {sav1.Balance}");
            try
            {
            //sav1.Withdraw(50);
            sav1.Deposit(-70);
            }
            catch (AmountMustBePositiveException ambpex)
            {
                Console.WriteLine(ambpex.Message);
            }
            catch(InsuffiecientFundsException ifex)
            {
                Console.WriteLine(ifex.Message);
                return;
            }
            Console.WriteLine($"Savings balance is {sav1.Balance}");
            Console.WriteLine($"Savings balance is {sav1.Balance}");
            Console.WriteLine($"");
           
            
            var interest = sav1.Interest(3);    // what is the interest on sav1 after three months
            Console.WriteLine($"Interest ammount is {interest}");
            sav1.PayInterest(3);
            Console.WriteLine($"Savings balance is {sav1.Balance}");
            Console.WriteLine($"");

            /*
            var acct1 = new Account("Acct102", "Greg's Account");
            Console.WriteLine($"account {acct1.Accountnumber} balance is {acct1.Balance}"); //writing the first balance
            acct1.Deposit(200);                                                              //depositing into account
            Console.WriteLine($"account {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Withdraw(30);                                                              //withdraw from the account
            Console.WriteLine($"account {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Withdraw(230);
            Console.WriteLine($"account {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Deposit(-200);
            Console.WriteLine($"account {acct1.Accountnumber} balance is {acct1.Balance}");
            Console.WriteLine($"");

            var sav2 = new SavingsInherate();    // creating new savings account with SavingIherate
            sav2.Deposit(60);
            Console.WriteLine($"Savings balance is {sav2.Balance}");
            sav2.Withdraw(30);
            Console.WriteLine($"Savings balance is {sav2.Balance}");
            sav2.Withdraw(50);
            Console.WriteLine($"Savings balance is {sav2.Balance}");
            sav2.Deposit(70);
            Console.WriteLine($"Savings balance is {sav2.Balance}");
            sav2.PayInterest(3);
            Console.WriteLine($"Savings balance is {sav2.Balance}");
            Console.WriteLine($"");
            */
        }
    }
}
