using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace BankAccount
{
    public class BankAccount : AccountDetails
    {
        private decimal balance;
        public enum Status
        {
            Open,
            Closed
        }


        public Status status { get; set; }

        

      
        private List<BankAccount> transactions = new List<BankAccount>();

        public BankAccount(decimal balance) : base(name: "Karim", 1930602226735)
        {
            this.balance = balance;
        }

        public void Withdrawal()
        {
            Console.WriteLine("Please enter an amount:");

            decimal withdrawal = Convert.ToDecimal(Console.ReadLine());


            if (status == Status.Open)
            {


                if (withdrawal <= 0)
                {
                    Console.WriteLine("Please enter a positive amount");
                }

                 if (balance - withdrawal < 0)
                {

                    Console.WriteLine("You don't have enough money");

                }

                if (balance - withdrawal > 0)

                {
                    balance -= withdrawal;
                    Console.WriteLine($"Current balance = {balance}");
                }
            }
            else
            {

                Console.WriteLine($"Your account has been closed and you can not make withdrawals");

            }

            var w = new BankAccount(balance);

            transactions.Add(w);

        }

        public void MakeDeposit()
        {
            Console.WriteLine("Please enter an amount:");

            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            
            

            if (status == Status.Open)
            {
                if (deposit <= 0)
                {
                    Console.WriteLine("Please enter a positive amount");
                }

                else
                {

                    balance += deposit;
                    Console.WriteLine($"Current balance = {balance}");
                }
            }

            else
            {

                Console.WriteLine($"Your account is closed and you can not process a deposit action");

            }

            var d = new BankAccount(balance);
            transactions.Add(d);
        }


        public void CloseAccount()
        {
            status = Status.Closed;
            Console.WriteLine("Your account has been closed");
        }

        public void InitialBalance()
        {
            Console.WriteLine($"Your balance:{balance}");
        }

        public void Statement()
        {
            Console.WriteLine($"Details about your account:");
            Console.WriteLine($"Full Name:{Name}");
            Console.WriteLine($"ID:{ID}");
            

        }
    }
}
