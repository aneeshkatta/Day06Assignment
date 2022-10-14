using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6logicalproblems
{
    public class Primecheck
    {
        public static void prime()
        {
            Console.WriteLine("Enter the Number to check its prime No. or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
                for (int i = 1; i <= num ; i++)
                {
                if (num % i == 0)
                { count++; }
                }
            if (count >=1 && num != 0 && num != 1)
            { Console.WriteLine(num + " is not a prime number"); }
            else
            { Console.WriteLine(num + " is prime number"); }
        }
        }

    }



