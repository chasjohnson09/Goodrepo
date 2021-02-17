using System;
using System.Collections.Generic;
using System.Text;

namespace Bankingtest2
{
    class Account
    {
        public int Accountnumber { get; set; }
        public int Routingnumber { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                return;
            }
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine($"Insfficient funds");
            }
        }
        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                Balance += amount;
            }
        }
    }
}
















////        public void Deposit(decimal amount)
////        {
////            if(amount > 0)
////            {
////                Balance += amount;
////            }

////        }
        
////        public void Withdraw(decimal amount)
////        {
////            if(amount < 0)
////            {
////                return;
////            }
////            if(Balance >= 0)
////            {
////                Balance -= amount;
////            }
////            else
////            {
////                Console.WriteLine($"Insufficient funds");
////            }
////        }
////    }
////}

        
        
        
        
        
//        /*
//        public int Accountnumber { get; set; }
//        public int Routingnumber { get; set; }
//        public string Description { get; set; }
//        public decimal Balance { get; set; }    */

//        public void Deposit(decimal amount)
//        {
//            if(amount > 0)
//            {
//                Balance += amount;
//            }
//        }

//        public void Withdraw(decimal amount)
//        {
//            if(amount < 0)
//            {
//                return;
//            }
//            if(Balance >= amount)
//            {
//                Balance -= amount;
//            }
//            else
//            {
//                Console.WriteLine($"Insufficient funds");
//            }
//        }

//    }
//}
       