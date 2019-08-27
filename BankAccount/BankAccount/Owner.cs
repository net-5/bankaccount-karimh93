using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Owner
    {
        private long iD;
        private string name;
        private string location;


        

        public long Id { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Location { get { return location; } set { location = value; } }


        public Owner(string name,long iD,string location)
        {
            this.Name = name;
            this.Id = iD;
            this.Location = location;
        }
    }
}
