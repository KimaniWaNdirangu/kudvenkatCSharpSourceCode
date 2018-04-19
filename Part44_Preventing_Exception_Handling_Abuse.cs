using System;
// Part 44 - Preventing Exception Handling Abuse
class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter the Numerator : ");
            int Numerator;

            bool IsNumeratorConversionSuccesful = Int32.TryParse(Console.ReadLine(), out Numerator);

            if (IsNumeratorConversionSuccesful)
            {
                Console.Write("Enter the Denominator : ");
                int Denominator;

                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConversionSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("Result = {0}", Result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("Denominator cannot be zero.");
                    }
                    else
                    {
                        Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                    }
                }
            }
            else
            {
                Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
        } // End try block
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } // End Main method
} // End class Program