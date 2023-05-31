using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class NestedInstructions
    {
        public void Method(bool argument)
        {
            if (argument == true)
            {
                Console.WriteLine("is true");
            }
        }
        
        // you can reduce the number of brackets and nested blocks with this simple trick:
         
        public void CleanCodeMethod(bool argument)
        {
            if (!argument)
                return;

            Console.WriteLine("is true");
            
        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck