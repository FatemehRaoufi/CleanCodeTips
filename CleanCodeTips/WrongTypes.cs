using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class WrongTypes
    {
        public void Method() 
        {
            int[] array1 = new int[5];
            int[] array2 = new int[6];
            int[] array3 = new int[9];

            int[] all = new int[array1.Length + array2.Length + array3.Length];

            array1.CopyTo(all,0);
            array2.CopyTo(all,array1.Length);
            array3.CopyTo(all, array1.Length + array2.Length);

        }

        //You just need to use proper types and everything begins to look better:
        public void CleanCodeMethod()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[6];
            int[] array3 = new int[9];

            List<int> allElements = new List<int>();
            allElements.AddRange(array1);
            allElements.AddRange(array2);
            allElements.AddRange(array3);

            int[] all = allElements.ToArray();

        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck