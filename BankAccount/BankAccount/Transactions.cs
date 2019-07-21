using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BankAccount
{
    public class Transactions : AccountDetails
    {

        public enum Status
        {
            Open,
            Closed
        }

        public Status status { get; set; }
        public decimal Money { get; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;

                foreach(var a in transactions)
                {
                    balance += a.Money;
                }

                return balance;
            }
            set
            {
               
            }
        }


        private readonly List<Transactions> transactions = new List<Transactions>();

        public Transactions(decimal money) : base(name: "Karim", 1930602226735)
        {
            this.Money = money;



        }


        public void Withdrawal()
        {

            Console.WriteLine("Please enter an amount:");
            decimal withdrawal = Convert.ToDecimal(Console.ReadLine());

            decimal balance = Balance;

            if (status == Status.Open)
            {
                if (withdrawal <= 0)
                {
                    Console.WriteLine("Please enter a positive amount");
                }

                else if (balance - withdrawal < 0)
                {

                    Console.WriteLine("You don't have enough money");
                }
            }
            else
            {

                Console.WriteLine($"Your account has been closed and you can not make withdrawals");

            }

            var w = new Transactions(Money);

            transactions.Add(w);


        }

        public void MakeDeposit()
        {
            Console.WriteLine("Please enter an amount:");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            decimal balance = Balance;

            if (status == Status.Open)
            {
                if (deposit <= 0)
                {
                    Console.WriteLine("Please enter a positive amount:");
                }

                else
                {

                    balance += deposit;
                }

            }

            else
            {

                Console.WriteLine($"Your account is closed and you can not process a deposit action");

            }
            var d = new Transactions(Money);
            transactions.Add(d);
        }


        public void CloseAccount()
        {
            status = Status.Closed;
            Console.WriteLine("Your account has been closed");
        }

        public void Statement()
        {
            Console.WriteLine($"Details about your account:");
            Console.WriteLine($"Full Name:{Name}");
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Last Activity:{LastActivity}");
            Console.WriteLine($"Your balance:{Balance}");

        }



    }
}
