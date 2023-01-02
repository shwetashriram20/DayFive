using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Payment
    {
        public static void CalPayment()
        {
            int n = 0;
            double R = 1;
            Console.WriteLine("Monthly Payment");
            Console.WriteLine("Enter the value : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of intrest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" The Monthly Payment is:");

            n = 12 * y;
            R = r / 3000;

            double monthlyPayment = (p * R) / (1 - Math.Pow((1 + R), n));
            Console.WriteLine("The Monthly Payment: {0}", monthlyPayment);

        }
    }
}