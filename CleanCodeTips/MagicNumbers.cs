using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class MagicNumbers
    {
        public int Method()
        {
            bool usePassword = true;
            if (usePassword)
                return 5;
            else
                return -2;

            return -1;
        }

        //using constants or some enums as Clean Codes:
      
        public enum State
        {
            Valid = 5,
            Invalid= -2
        }
        public State CleanCodeMethod()
        {
           return State.Valid;
        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck