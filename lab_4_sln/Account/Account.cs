using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Account
    {
        string acName;
        string acid;
        int balance;

        public string AcName
        {
            set { acName = value; }
            get { return acName; }
        }

        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public Account() { }

        public Account(string acName, string acid, int balance)
        {
            this.acName = acName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Money Deposit Completed.");
            Console.WriteLine();
        }

        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Money Withdraw Completed.");
        }
        public void Transfer(int amount, Account acc)
        {
            balance = balance - amount;
            acc.Balance = acc.Balance + amount;
            Console.WriteLine("Balance Transfered.");
        }
    }
}