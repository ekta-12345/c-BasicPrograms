using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class Powerofn
    {
        public void ReadInput()
        {


            Console.Write(" Input the power : ");  
            //taking input from the user 
            int result = Convert.ToInt32(Console.ReadLine());
            
            int limit = 31;
      
            if(result > limit)
            {
                Console.WriteLine($"You Enter {result}  of 2^ exceeds the value limit 31  ");
                // condition not equal to show message
            }
            else
            {

                for (int i = 1; i <= result; i++)
           
               Console.WriteLine($"{2}^{i} = {(long)Math.Pow(2, i)}");
               //print the table for powers of two

              /*  double pw = Math.Pow(2, result);
                Console.WriteLine(pw);*/
            }

           

        }
    }
}

