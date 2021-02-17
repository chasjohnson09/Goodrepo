using System;

namespace Bankingtest2
{
    class Program
    {
        static void Main(string[] args)
        {

            var acct1 = new Account2();
            acct1.Accountnumber = 101;
            acct1.Deposit(200);
            Console.WriteLine($"Account number {acct1.Accountnumber}'s balance is {acct1.Balance}");
            acct1.Withdraw(130);
            Console.WriteLine($"Account number {acct1.Accountnumber}'s balance is {acct1.Balance}");
            acct1.Deposit(40);
            Console.WriteLine($"Account number {acct1.Accountnumber}'s balance is {acct1.Balance}");
            acct1.Withdraw(150);
            Console.WriteLine($"Account number {acct1.Accountnumber}'s balance is {acct1.Balance}");

        }
    }
}


            
            
            /*
            var acct1 = new Account();
            acct1.Accountnumber = 101;
            Console.WriteLine($"Account number {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Deposit(300);
            Console.WriteLine($"Account number {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Withdraw(128);
            Console.WriteLine($"Account number {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Deposit(300);
            Console.WriteLine($"Account number {acct1.Accountnumber} balance is {acct1.Balance}");
            acct1.Withdraw(245);
            Console.WriteLine($"Account number {acct1.Accountnumber} balance is {acct1.Balance}");
        }
    }
}
*/