using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6logicalproblems
{
    internal class Coupon
    {
        public static void GenerateCoupon()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var StringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < StringChars.Length; i++)
            {
                StringChars[i] = chars[random.Next(chars.Length)];
                
            }

            var CouponNumber = new String(StringChars);
            Console.WriteLine("coupon number is " + CouponNumber);

        }
    }
}
