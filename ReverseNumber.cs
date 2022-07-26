using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void ReverseDigit()
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string ReverseDigit = ""; int digit = 0;
            do
            {
                digit = num % 10;
                ReverseDigit = ReverseDigit + digit;
                num = num / 10;
            } while (num != 0);
            Console.WriteLine("Reverse Number is : " + ReverseDigit);
        }
    }
}

