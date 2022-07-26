using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter the number to check Prime :");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number is Not a PrimeNumber :");
                    flag++;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is PrimeNumber");
            }
        }
    }
}
