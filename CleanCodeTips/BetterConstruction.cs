using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class BetterConstruction
    {
        public void Method(bool boolean, int integer) {
            /*
                if (boolean) 
                {
                    Console.WriteLine("True");
                }
                else
                {
                    if (integer > 0) {
                        Console.WriteLine("positive");
                    }
                }
            */
            //BetterConstruction:
            if (boolean)
            {
                Console.WriteLine("True");
            }
            else if (integer > 0)
                {
                    Console.WriteLine("positive");
                }
            
        }
    }
}

//Source: https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck