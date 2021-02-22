using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Fixed : Account
    {
        int tenureYear = 2, year;

        public Fixed() { }
        public Fixed(string acName, string acid, int balance, int year)
            : base(acName, acid, balance)
        {
            this.year = year;
        }

        new public void Withdraw(int amount)
        {
            if (tenureYear == this.year)
                base.Withdraw(amount);
            else
                Console.WriteLine("Account need to mature."); Console.WriteLine();
        }

        new public void Deposit(int amount) { base.Deposit(amount); }

        new public void Transfer(int amount, Account acc)
        {
            if (tenureYear == this.year)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Account need to mature."); Console.WriteLine();
        }
    }
}
