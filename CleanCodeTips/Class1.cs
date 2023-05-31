using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class Class1
    {
        public void Method()
        {
            int integer = 5;
            string text = "text";
            string trimmedText = text.Trim();
            trimmedText = trimmedText + integer;
            for (int i = 0; i < 10; i++)
            {
                integer = integer + i;
            }
            trimmedText = trimmedText + integer;
        }
     
        // Mentioned above block of code is barely readable.
        // You can remove some unnecessary code and
        // add some lines to improve readability:
        public void CleanCodeMethod()
        {
            int integer = 5;
            string text = "text";

            string trimmedText = text.Trim() + integer;
            
            for (int i = 0; i < 10; i++)
            {
                integer = integer + i;
            }
            trimmedText = trimmedText + integer;
        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck