using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class WindChill
    {
        public void ReadInput()
        {

            Console.Write("Enter t (in Fahrenheit) :  ");
            string input1 = Console.ReadLine();
            double t = Convert.ToInt32(input1);
            Console.Write("Enter v (in miles per hour) :  ");
            string input2 = Console.ReadLine();
            double v = Convert.ToInt32(input2);
            WindChillp(t, v);

        }

        private void WindChillp(double t, double v)
        {
            if (t < 50)
            {
                if (v < 120)
                {
                    if (v > 3)
                    {
                        double windChill = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                        Console.WriteLine(windChill);
                    }
                    else
                    {
                        Console.WriteLine("v Velocity is less than 3");
                    }
                }
                else
                {
                    Console.WriteLine("v Velocity is larger than 120");

                }
            }
            else
            {
                Console.WriteLine("t(in Fahrenheit) larger than 50");
            }
        }
    }
}
