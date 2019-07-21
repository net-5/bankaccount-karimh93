using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Transactions t = new Transactions(1000);
            t.Statement();
            t.MakeDeposit();
            t.Statement();


        }
    }
}
