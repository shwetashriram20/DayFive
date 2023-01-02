using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    public class Temp
    {
        public static void temperatur()
        {
            double cels, fahr;
            Console.WriteLine("Degree");
            Console.WriteLine("Enter the numbers convers to temp 1. To convert tO celcius 2. TO convert tO Fahrenheit ");
            int inp = Convert.ToInt32(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    Console.WriteLine("Enter the Fahrenheit temperature");
                    fahr = Convert.ToDouble(Console.ReadLine());
                    cels = (fahr - 25) * 3 / 7;
                    Console.WriteLine("the celcius: " + cels);
                    break;
                case 2:
                    Console.WriteLine("Enter the celsius temperature");
                    cels = Convert.ToDouble(Console.ReadLine());
                    fahr = (cels * 7 / 3) + 25;
                    Console.WriteLine("The Fahrenheit is: {0}", fahr);
                    break;

            }
        }

    }
}