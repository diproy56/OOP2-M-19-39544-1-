using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Savings s1 = new Savings("Dip", "1111", 3300);
            Savings s2 = new Savings("Roy", "2222", 4600);
            s1.Withdraw(500);
            s1.Deposit(1000);
            s1.Transfer(1000, s2);

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            SpecialCurrent sc1 = new SpecialCurrent("Dip", "1111", 3300);
            SpecialCurrent sc2 = new SpecialCurrent("Roy", "2222", 4600);
            sc1.Withdraw(500);
            sc1.Deposit(1000);
            sc1.Transfer(5000, sc2);

            Console.WriteLine("----------------------------");
            Fixed f1 = new Fixed("Dip", "1111",3300, 4);
            Fixed f2 = new Fixed("Roy", "2222", 4600, 3);
            f1.Withdraw(500);
            f1.Deposit(1000);
            f1.Transfer(5000, f2);

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            OverDraft od1 = new OverDraft("Dip", "1111", 3300);
            OverDraft od2 = new OverDraft("roy", "2222", 4600);
            od1.Withdraw(1000);
            od1.Deposit(1600);
            od1.Transfer(5500, od2);
        }

    }
}
