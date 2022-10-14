using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6logicalproblems
{
    internal class uc1_fibannoci
    {
        public static void fibanociseries()
        {
            Console.WriteLine("enter two numbers of fibanociseries ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of elements: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " "); //printing 0 and 1    
            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                int c = a + b;
                Console.WriteLine(c + " ");
               a = b;
               b = c;
            }
        }

    }
} 

