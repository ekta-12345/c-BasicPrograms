using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class TripletsWith_Hashset
    {
        public static void FindHashTriplets()
        {
            int[] array = { 12, -5, -5, 6, 10 };
            int n = array.Length;
            bool found = false;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < n ; i++)
               
            {

                for (int j = i + 1; j < n; j++)
                {
                    
                    int thirdValue = -(array[i] + array[j]);
                    if (set.Contains(thirdValue))
                    {
                        Console.WriteLine("[" + array[i] + "," + array[j] + "," + thirdValue + "]");
                        found = true;
                    }
                    else
                    {
                        set.Add(array[j]);
                    }


                    

                }
            }


            if (found == false)
                Console.WriteLine("Triplets are not present in the given array");
        }
    }



}





