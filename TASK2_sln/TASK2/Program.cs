using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    class Program
                {
                    static void Main(string[] args)
                    {
                        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                     Console.WriteLine(string.Join(",", nums));
                     var sum = 0;
                        for (var i = 0; i < nums.Length; i++)
                        {
                            sum += nums[i];
                        }
                       Console.WriteLine("Sum: "+ sum);
                } 
            }
        }
