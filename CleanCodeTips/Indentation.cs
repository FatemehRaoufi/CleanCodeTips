using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class Indentation
    {
        public void Method(int argument)
        {
            string text = "text";
            text = text + argument;
         }

        public void CleanCodeMethod(int argument)
        {
            string text = "text" + argument; 
        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck