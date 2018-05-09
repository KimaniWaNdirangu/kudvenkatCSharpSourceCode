using System;
using System.Runtime.InteropServices;

// Part 70 - Optional Parameteres - OptionalAttribute in System.Runtime.InteropServices
namespace Kudvenkat.CSharp
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional]int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }              
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}

