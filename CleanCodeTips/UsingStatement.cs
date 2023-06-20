using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTips
{
    public class UsingStatement
    {
        /*
         You can use it to easily avoid memory leaks, 
        which are common if you don’t use them. 
        A memory leak is where the .NET garbage collector doesn’t know that your object is no longer being used. 
        So, when you try to run your program, 
        the .NET garbage collector will not free up memory because it doesn’t know that those objects are no longer needed. 
        The using statement will solve this problem.
          */
        public UsingStatement() {

            var numbers = new List<int>();
            using (StreamReader reader = File.OpenText("numbers.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) is not null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        numbers.Add(number);
                    }
                }
            }

            //--------------------
            static IEnumerable<int> LoadNumbers(string filePath)
            {
                using StreamReader reader = File.OpenText(filePath);

                var numbers = new List<int>();
                string line;
                while ((line = reader.ReadLine()) is not null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        numbers.Add(number);
                    }
                }
                return numbers;
            }
            //--------------------------
        }
    }
}

//https://methodpoet.com/clean-code/
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/using