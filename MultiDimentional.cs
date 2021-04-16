using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{

    class MultiDimentional
    {
        public static void ReadMultiArray()
        {
            object[][] array = new object[4][];
            array[0] = new object[4]; //integer
            array[1] = new object[4]; //boolean
            array[2] = new object[4]; // string
            array[3] = new object[4]; // double

            Console.WriteLine("Enter integer array of 4 elements");
            for (int i = 0; i < 4; i++)
            {
                array[0][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter boolean array of 4 elements");
            for (int i = 0; i < 4; i++)
            {
                array[1][i] = Convert.ToBoolean(Console.ReadLine());
            }

            Console.WriteLine("Enter string array of 4 elements");
            for (int i = 0; i < 4; i++)
            {
                array[2][i] = Console.ReadLine();
            }

            Console.WriteLine("Enter double array of 4 elements");
            for (int i = 0; i < 4; i++)
            {
                array[3][i] = Convert.ToDouble(Console.ReadLine());
            }

            // Iterating over the Object array
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}