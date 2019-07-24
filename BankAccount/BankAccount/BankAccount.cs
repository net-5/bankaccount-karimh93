﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace BankAccount
{
    public class BankAccount
    {
        private decimal balance;
        public enum Status
        {
            Open,
            Closed
        }

        public string AccountNumber { get; }
        public string Owner { get; }

        public Status status { get; set; }

        private List<AccountDetails> accountDetails = new List<AccountDetails>();

        public BankAccount(string owner,decimal balance,string accountNumber)
        {
            this.balance = balance;
            this.Owner = owner;
            this.AccountNumber = accountNumber;
        }

        public void Withdrawal(decimal amount, string name)
        {


            if (status == Status.Open)
            {


                if (amount <= 0)
                {
                    Console.WriteLine("Please enter a positive amount");
                }

                if (balance - amount < 0)
                {

                    Console.WriteLine("You don't have enough money");

                }

                if (balance - amount > 0)

                {
                    balance -= amount;
                    Console.WriteLine($"Current balance = {balance}");
                }
            }
            else
            {

                Console.WriteLine($"Your account has been closed and you can not make withdrawals");

            }

            var w = new AccountDetails(amount, name);
            accountDetails.Add(w);

        }

        public void MakeDeposit(decimal amount, string name)
        {



            if (status == Status.Open)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Please enter a positive amount");
                }

                else
                {

                    balance += amount;
                    Console.WriteLine($"Current balance = {balance}");
                }
            }

            else
            {

                Console.WriteLine($"Your account is closed and you can not process a deposit action");

            }

            var d = new AccountDetails(amount, name);
            accountDetails.Add(d);
        }


        public void CloseAccount()
        {
            status = Status.Closed;
            Console.WriteLine("Your account has been closed");
        }

        public void Statement()
        {
            Console.WriteLine($"Owner name:{Owner}");
            Console.WriteLine($"Account number:{AccountNumber}");
            Console.WriteLine($"Your balance:{balance}");
        }
    }
}

