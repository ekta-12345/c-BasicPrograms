using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{

    class LeapYear
    {       //Create Class
        public void ReadInput()
        {    //Reading input from user
            Console.Write("Enter a Year:- ");
            string leapyear = Console.ReadLine();
            int year = Convert.ToInt32(leapyear);
            //convert from string into integer value
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) //Century Year such as 1900 2100 2000 ...
                Console.WriteLine($"Year {year} is a Leap Year");
            else
                Console.WriteLine($"Year {year} is Not a Leap Year");


        }
    }
}