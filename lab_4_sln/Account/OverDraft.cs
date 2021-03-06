﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class OverDraft : Account
    {
        int limit = 50000;

        public OverDraft() { }
        public OverDraft(string acName, string acid, int balance)
            : base(acName, acid, balance)
        {
            base.Balance = balance + limit;
        }

        new public void Withdraw(int amount)
        {
            if (base.Balance >= amount)
                base.Withdraw(amount);
            else
                Console.WriteLine("Insaficient Balance."); Console.WriteLine();
        }

        new public void Deposit(int amount) { base.Deposit(amount); }

        new public void Transfer(int amount, Account acc)
        {
            if (base.Balance >= amount)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Insaficient Balance."); Console.WriteLine();
        }
    }
}
