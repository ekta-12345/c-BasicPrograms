using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class sumOfTriplets
    {
        public static void FindTriplets()
        {
            int[] array = { 12, -5, -5, 6, 10 };
           
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {

                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            found = true;
                            Console.WriteLine("[" + array[i] + "," + array[j] + "," + array[k] + "]");
                        }

                    }

                }
            }


            if (found == false)
                Console.WriteLine("Triplets are not present in the given array");
        }
    }
        
    

}
