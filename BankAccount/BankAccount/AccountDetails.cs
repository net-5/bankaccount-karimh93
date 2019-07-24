using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BankAccount
{
    public class AccountDetails
    {
        public string Name { get; }
        
        public decimal Money { get; }

        public AccountDetails(decimal money,string name)
        {

            this.Money = money;
            this.Name = name;
            
            

        }
    }
}




