using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class AdequateConstruction
    {
        //Inadequate construction
        public void InadequateMethod() 
        {
            IList<int> integers = new List<int>()
            {
                5,
                4,
                10
            };
            for (int i = 0;i < integers.Count; i++)
            {                
                Console.WriteLine (integers[i]);             
            }


        }
        //adequate construction
        public void AdequateMethod()
        {
            IList<int> integers = new List<int>()
            {
                5,
                4,
                10
            };
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }
        }
        public void AdequateCheckingListMethod()
        {
            IList<int> integers = new List<int>();
           
            if (integers.Count > 0)
            {
                foreach (int i in integers)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
        //As you can see, integers list is empty –
        //there is no point in checking if has no elements as for each loop will do it for us automatically
        // There for we can remove: if (integers.Count > 0) and write:
       /* 
          IList<int> integers = new List<int>();
          foreach (int i in integers)
                {
                    Console.WriteLine(i);
                }   
        */
                
}
    
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck