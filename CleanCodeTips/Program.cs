/*
 Is there a magic number on how long the method should be? 
No. It should be long enough to do only one thing. 
But it should not have more than, let’s say, 20-30 lines. 
Of course, your method could be longer and be perfect, 
but try to keep them as short as possible.

 */
using CleanCodeTips;
using static CleanCodeTips.MethodParameters;
/*
 #Write short methods when developing code

    Short methods keep your code more organized and readable. 
    Short methods are also easier to debug. 
    If there is a problem with a method, you can quickly isolate it and fix it. 
    That is much harder to do if the method is long and complex.

    Additionally, if you need to change to a lengthy method, you may have to scroll through a lot of code to find the right place.
 
 */
class Program
{
    static void Main(string[] args)
    {
        
        
        /* 
        ExtractMethod,
        Using PrintOutput(); method,
        instead of using directly these codes:  
            Console.WriteLine("Hello World!");
            Console.WriteLine("I'm going to a new method.");
        in Main method.
        */


        // PrintOutput();

    }
    private static void PrintOutput()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("I'm going to a new method.");
        //https://methodpoet.com/clean-code/
        /*

         MethodParameters methodParameters = new MethodParameters();
         var addressDetsils = new AddressDetails
         {
             Name = "John",
             HomeAddress = "New York",
             Country = "USA",
             Email = "john@methodpoet.com",
             FileLocation = "C:\\temp"
         };
         //methodParameters.NewSaveHomeAddress("John",
         //    "New York",
         //    "USA",
         //    "john@methodpoet.com",
         //    "C:\\temp",
         //    addressDetsils);
         methodParameters.CleanCodeSaveHomeAddress(addressDetsils);
        */


    }

}

//https://methodpoet.com/extract-method/

//https://methodpoet.com/clean-code/
//https://methodpoet.com/refactor-nested-if-statements/
