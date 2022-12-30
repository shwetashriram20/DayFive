using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    public class PrimeNumber
    {
        public static void checkPrimeNumber()
        {
            int i = 2;
            
            Console.WriteLine("enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < a; i++)
                if (a % i == 0)
                {
                    Console.WriteLine("the number is prime");
                }
                else
                {
                    Console.WriteLine("the number is not prime");
                }
        }
    }
}
