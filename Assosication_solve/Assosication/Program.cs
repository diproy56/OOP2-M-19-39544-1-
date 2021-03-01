using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosication
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("Roy", "12345", 2.1f);
            student s2 = new student("Dip", "54321", 2.5f);
            student s3 = new student("joy", "78901", 3.1f);

            Department d1 = new Department("Computer science", "CS");
            Department d2 = new Department("English", "English");
            s1.Dept = d1;
            d1.AddStudent(s1, s2, s3);
            d1.AddStudent(s2);
            s2.Dept = d2;
            s3.Dept = d2;
            d2.AddStudent(s3);
            s1.ShowInfo();
            s3.ShowInfo();
            Console.WriteLine("***************");
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s2.ShowSudentDeatils();
            Console.WriteLine("***************");
            d2.PrintStudent();
            s3.Name = "MR.X";
            d2.PrintStudent();

        }
    }
}
