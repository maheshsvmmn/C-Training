using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Account
    {
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string accountType;
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }

        }

        double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public bool WithDraw(double amt)
        {
            if (balance < amt) return false;
            balance -= amt;
            return true;
        }

        public string GetDetails()
        {
            return $"Account Id : {id} \nAccount Type : {accountType}\nBalance : {balance}\n";
        }
    }
}
