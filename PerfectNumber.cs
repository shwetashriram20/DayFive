using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    public class PerfectNumber
    {
        public static void perfectDisplayNumber()
        {
            int n, i, sum;
            int mn, mx;

            Console.WriteLine("Find the perfect numbers within a given number of range:");

            Console.WriteLine("Input the starting range or number: ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending rangr or number: ");
            mx = Convert.ToInt32(Console.ReadLine());

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + 1;
                    i++;

                    Console.WriteLine("The perfect number within given range");
                }
            }
        }

    }
}
    

