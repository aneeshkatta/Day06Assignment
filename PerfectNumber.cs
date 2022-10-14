using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6logicalproblems
{
     class PerfectNumber
    {
        public static void Perfectnumber()
        {
            int number, sum = 0;
            Console.WriteLine("Enter the Number to check its perfect No. or Not");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n Entered number is a perfect number");
               
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                
            }

        }
        }
    }

