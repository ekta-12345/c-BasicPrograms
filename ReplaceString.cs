using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class ReplaceString
    {
        /// <summary>
        /// Reading input from the user
        /// </summary>
        public void ReadInput()
        {
            // given string template
            string template = "Hello <<UserName>>, How are you?";
            // giving instruction/message to the user
            Console.WriteLine("Please enter your name");
            // Reading input from user
            string userInput = Console.ReadLine();
            //calling reaplace() method
            ReplaceWord(template, userInput);
        }
        /// <summary>
        /// Created replace() method to perform replacement
        /// </summary>
        /// <param name="template"></param>
        /// <param name="userInput"></param>
        private void ReplaceWord(string template, string userInput)
        {
            //using predefined string Replace() method to perform replace operation
            string result = template.Replace("<<UserName>>", userInput);
            // finally displaying updated template/statement
            Console.WriteLine("After done replace\t" + result);
        }
    }
}