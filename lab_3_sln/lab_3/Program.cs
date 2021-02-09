using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("DIP", "19-39544-1", "CSE", 3.07F);
            s1.ShowInfo();
            Console.WriteLine("----------------------------------------------");

            Triangle t1 = new Triangle(6, 4, 4);
            t1.ShowInfo();
            t1.TestTriangle();
            Console.WriteLine("----------------------------------------------");

            Account a1 = new Account("ROY", "55055", 1000);
            Console.Write("How much money do want to deposit? Enter Amount : ");
            int mdeposit = int.Parse(Console.ReadLine());
            a1.Deposit(mdeposit);
            Console.Write("How much money do want to withdraw? Enter Amount : ");
            int mwithdraw = int.Parse(Console.ReadLine());
            a1.Withdraw(mwithdraw);
            Console.WriteLine("----------------------------------------------");

            Course c1 = new Course("OOP2", "CSC3302", 3);
            c1.ShowCourseInfo();
            Console.ReadLine();
        }
    }
}
