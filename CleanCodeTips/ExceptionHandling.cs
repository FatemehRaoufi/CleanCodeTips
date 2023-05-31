using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class ExceptionHandling
    {
        /*
              
        public void Method()
        {
            object retval = MethodWithReturn(false);
            if (retval  is string)
            {
                Console.WriteLine("yes");
            }
            else if (retval is Exception) 
            { 
            Console.WriteLine("no");
            
            }
        }
        public object MethodWithReturn(bool argumnet)
        {
            if (argumnet)
            {
                return string.Empty;

            }
            else 
            { 
               return new Exception();
            }
        }
        */
        /*
         In above code:
         MethodWithReturn returns very general type
         MethodWithReturn in one case returns an Exception object
         As you can see, the exception is not used properly. 
         Generally, those objects are not supposed to be returned. 
         The logic of our application is therefore controlled by returned object type.
         So:
         */
        public void Method()
        {
            try
            {
                if (MethodWithReturn(false)is string)
                    Console.WriteLine("yes");
            }
            catch
            {
                Console.WriteLine("no");
            }
            
        }
        public object MethodWithReturn(bool argumnet)
        {
            if (argumnet)
           
                return string.Empty;

            throw new Exception();
            
        }
    }
}
