using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class primeFactors
    {
        public void ReadInput()
        {
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a =Convert.ToInt32(Console.ReadLine());

            for (b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times!");
                }
            



        }
    }
}