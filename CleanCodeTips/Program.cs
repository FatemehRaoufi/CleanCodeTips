/*
 Is there a magic number on how long the method should be? 
No. It should be long enough to do only one thing. 
But it should not have more than, let’s say, 20-30 lines. 
Of course, your method could be longer and be perfect, 
but try to keep them as short as possible.

 */

using CleanCodeTips;
using static CleanCodeTips.MethodParameters;

class Program
{
    static void Main(string[] args)
    {
        PrintOutput();

    }
    private static void PrintOutput()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("I'm going to a new method.");
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


    }
  
}

//https://methodpoet.com/extract-method/

//https://methodpoet.com/clean-code/
//https://methodpoet.com/refactor-nested-if-statements/
