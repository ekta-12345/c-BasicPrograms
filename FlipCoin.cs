using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class FlipCoin
    {
        public void ReadInput()
        {
            Console.WriteLine("Please enter number of times to flip coin");
            string input = Console.ReadLine();
            //convert from string into int with the help Convert.ToInt32()
            int numbOfTimes = Convert.ToInt32(input);
            //calling Flip() method to find percentage
            Flip(numbOfTimes);
        }

        private static void Flip(int numbOfTimes)
        {
            // Intialization of local variables
            int tail = 0; int head = 0;
            //Object creation for predefined Random class
            Random random = new Random();
            //Using for loop to iterate till condition fails
            for (int i = 1; i <= numbOfTimes; i++)
            {
                //using random function called NextDouble() to get random value range between 0 to 1
                if (random.NextDouble() < 0.5)
                {
                    //incrementing tail count by 1
                    tail++;
                }
                else
                    //incrementing head count by 1
                    head++;
            }
            //Applying formula to find percentage
            double tailPercentage = (double)tail / numbOfTimes * 100;
            double headPercentage = (double)head / numbOfTimes * 100;
            //finally perinting count and also percentage for head and tail
            Console.WriteLine("Tail count" + "=" + tail + "\tPercentage " + tailPercentage);
            Console.WriteLine("Head count" + "=" + head + "\tPercentage " + headPercentage);
        }
    }
}


