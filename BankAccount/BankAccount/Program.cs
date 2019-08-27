using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount(new Owner("Karim Husein", 19243132132, "Iasi"));

            account.MakeDeposit(1000, "University");
            account.Withdrawal(200, "Groceries");

            account.Statement();
            
           
           
            
           


            
            
           
            
            


        }
    }
}
