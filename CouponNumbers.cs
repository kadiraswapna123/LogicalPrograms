using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        public static void CouponGenarator()
        {
            Random random = new Random();
            char[] charArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 
                'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','a','b','c','d','e','f','g','h','i','j','k','l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z' };

            Console.WriteLine("Enter the number Of Coupon:");
            int numberOfCoupon = Convert.ToInt32(Console.ReadLine()); //Converts the string representation of a number in a specified base

            Console.WriteLine("Your Coupon Number is :");
            while (numberOfCoupon > 0)
            {
                string emptyString = "";
                for (int i = 0; i <= 3; i++)
                {
                    int value = random.Next(0, 52);
                    char ch = charArray[value];
                    emptyString = emptyString + ch;
                }
                for (int i = 0; i < 3; i++)
                {
                    int value = random.Next(0, 9);
                    emptyString = emptyString + value;
                }
                Console.WriteLine(emptyString);
                numberOfCoupon--;
            }

        }
    }
}
