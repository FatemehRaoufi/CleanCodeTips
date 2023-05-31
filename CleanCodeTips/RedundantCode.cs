using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class RedundantCode
    {
        public void Method(bool usePassword) 
        {
          if (usePassword)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1);
                }
                Console.WriteLine("text");
            }
          else
            {
                Console.WriteLine("text");
                    
             }
        }

        //Here you can see a repeat of code. Let’s move it out of brackets.
        public void CleanCodeMethod(bool usePassword)
        {
            if (usePassword)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1);
                }
 
            }
           
                Console.WriteLine("text");

        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck