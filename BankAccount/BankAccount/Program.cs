using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

           BankAccount t = new BankAccount("Karim Husein",10000,"120211311");
            t.Statement();
            t.Withdrawal(2000, "Car");
            t.MakeDeposit(1000, "Salary");
            t.Statement();
            
           
           
            
           


            
            
           
            
            


        }
    }
}
