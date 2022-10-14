using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6logicalproblems
{
    internal class ReverseNo
    {
        
        public static void revno()
        {
            int reverse = 0;
            Console.WriteLine("Enter a number to reverse: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                int rem = num % 10;
                num = num/10;
                reverse = reverse * 10 + rem;
                            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
