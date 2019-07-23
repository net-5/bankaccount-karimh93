using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

           BankAccount t = new BankAccount(1000);
           
            t.Statement();
            t.InitialBalance();
            t.MakeDeposit();
            t.Withdrawal();
            t.MakeDeposit();
            t.CloseAccount();
            t.MakeDeposit();
           


            
            
           
            
            


        }
    }
}
