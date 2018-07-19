using System;
//Part 07 - Datatypes Conversion
class Program
{
    static void Main()
    {
        //float f = 1234567893456.45F;

        //int i = f; // May Cause Overflow Excepion and Truncate the decimal places

        //int i = (int)f; // ()Type Cast Operator - Loss of decimal places. Outputs '123'

        //int i = (int)f; // Outputs -2147483648 instead of throwing an Exception
        //int i = Convert.ToInt32(f);

        //Console.WriteLine(i);

        string strNumber = "100";

        //int i = int.Parse(strNumber);

        int result = 0;

        bool isConversionSuccesfull = int.TryParse(strNumber, out result);

        if(isConversionSuccesfull)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}


