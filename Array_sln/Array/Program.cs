using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 0 };
            int c = 1, ctr = 0, count;

            Console.WriteLine("Original array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Array in reverse order: ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            //sum
            {
                var sum = 0;
                for (var i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine("\nArray Sum: " + sum);
            }
            //duplicate
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr2[j])
                    {
                        arr2[j] = c;
                        c++;
                    }
                }
                c = 1;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == 2)
                {
                    ctr++;
                }
            }
            Console.WriteLine("Duplicate elements are: {0}", ctr);
            Console.WriteLine(" ");
            //unique_ellement
            for (int i = 0; i < arr.Length; i++)
            {
                int unique = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        unique = 1;

                    }
                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }


                }
                if (unique == 0)
                {
                    Console.WriteLine("unique number: {0}", arr[i]);

                }
            }
        }
    }
}





