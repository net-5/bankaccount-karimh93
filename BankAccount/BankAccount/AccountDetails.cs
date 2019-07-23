using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BankAccount
{
    public class AccountDetails
    {
        public string Name { get; }
        public long ID { get; }

        public AccountDetails(string name, long id)
        {
            this.Name = name;
            this.ID = id;

        }
    }
}




