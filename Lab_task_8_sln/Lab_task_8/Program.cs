using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, s1, s2, s3, s4, s5, t;
            Double p;
           
            Console.WriteLine("Enter N5umber \n");
            Console.WriteLine("Mark of Physics : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Chemistry: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Biology : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Math : ");
            s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Computer : ");
            s5 = Convert.ToInt32(Console.ReadLine());
            t = s1 + s2 + s3 + s4 + s5 ;
            p = t / 5.0f;
            
            Console.WriteLine("Percentage : " + p);
            if (p >= 0 && p < 50)
                 {
                     Console.WriteLine("Grade is F");
                 }
            if (p >= 50 && p < 74)
                 {
                     Console.WriteLine("Grade is C+");
                 }
            if (p >= 75 && p <= 79)
                 {
                      Console.WriteLine("Grade is B");
                 }
            if (p > 80 && p <= 84)
                 {
                      Console.WriteLine("Grade is B+");
                 }
            if (p > 85 && p <= 89)
                 {
                       Console.WriteLine("Grade is A");
                  }
            if (p > 90 && p <= 100)
                  {
                       Console.WriteLine("Grade is A+");
                 }
            Console.ReadLine();
        }
    }
}