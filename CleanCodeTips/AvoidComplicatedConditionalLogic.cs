//#using Code Clean up to removing unnecessary codes:
/*
Ctrl + K, Ctrl + D keys or run Code Cleanup inside Visual Studio is to click on the broom icon.
That will run the following actions:

Format document
Remove unnecessary usings
Sort usings
Apply file header preferences

 */
//....................................................
/*
#Avoid complicated conditional logic in your code by refactoring nested ifs.

    There might be cases in your code where you have nested conditional logic. 
    You know, if inside if, inside if. 
    I call that code Ifception.
    The easiest way to refactor nested if statements is to use a guard clause. Visual Studio has the Invert if code fix for nested if statements
 */
namespace CleanCodeTips
{
    public class AvoidComplicatedConditionalLogic
    {
        public static bool IsFibonnaciNumber(int number)
        {
            //To quickly remove nesting, we can use the Invert if. Start with the first if statement,
            //position your cursor at the if, and select the Invert if option.
            
            //The Code befor Invert if:
            /*
                        if (number != 0)
                        {
                            if (number != 1)
                            {
                                if (number != 2)
                                {
                                    double fi = (1 + Math.Sqrt(5)) / 2.0;
                                    int n = (int)Math.Floor(Math.Log(number * Math.Sqrt(5) + 0.5, fi));

                                    int actualFibonacciNumber = (int)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 0.5);

                                    return actualFibonacciNumber == number;
                                }
                            }
                        }
                        return true;
            */
            // After Invert if:
            if (number == 0)
            {
                return true;
            }
            if (number != 1)
            {
                if (number != 2)
                {
                    double fi = (1 + Math.Sqrt(5)) / 2.0;
                    int n = (int)Math.Floor(Math.Log(number * Math.Sqrt(5) + 0.5, fi));

                    int actualFibonacciNumber = (int)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 0.5);

                    return actualFibonacciNumber == number;
                }
            }
            return true;
        }

        //After Refactoring:
        public static bool NewIsFibonnaciNumber(int number)
        {
            if (number == 0)
            {
                return true;
            }
            if (number == 1)
            {
                return true;
            }
            if (number == 2)
            {
                return true;
            }

            double fi = (1 + Math.Sqrt(5)) / 2.0;
            int n = (int)Math.Floor(Math.Log(number * Math.Sqrt(5) + 0.5, fi));

            int actualFibonacciNumber = (int)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 0.5);

            return actualFibonacciNumber == number;
        }
    }
    //.........................................................
    public class RemoveDuplicatedIfStatements
    {
        public static bool IsFibonnaciNumber(int number)
        {
            if (IsNumberWithinFirstThreeNumbers(number))
            {
                return true;
            }

            double fi = (1 + Math.Sqrt(5)) / 2.0;
            int n = (int)Math.Floor(Math.Log(number * Math.Sqrt(5) + 0.5, fi));

            int actualFibonacciNumber = (int)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 0.5);

            return actualFibonacciNumber == number;
        }

        private static bool IsNumberWithinFirstThreeNumbers(int number)
        {
            return number == 0 || number == 1 || number == 2;
        }
    }
}
//Source: https://methodpoet.com/clean-code/
//https://methodpoet.com/refactor-nested-if-statements/
//https://refactoring.guru/consolidate-conditional-expression
//https://methodpoet.com/ifception/