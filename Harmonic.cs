using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class Harmonic

    {
        public void ReadInput()
        {
            Console.Write("Enter a Number:- ");
            string NNumber = Console.ReadLine();
            int number = Convert.ToInt32(NNumber);
            Hnumber(number);
        }
        private static void Hnumber(int number)
        {

            double harmonic = 1; //identity value for
            for (int i = 2; i <= number; i++)
            {

                harmonic += (double)1 / i; //int int => harmonic +=1/i

            }

            Console.Write($"Harmonic value of {number} is {harmonic}");
        }
    }
}

