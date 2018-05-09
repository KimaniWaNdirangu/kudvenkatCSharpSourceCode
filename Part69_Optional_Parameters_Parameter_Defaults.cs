using System;

// Part 69 - Optional Parameteres - Parameter Arrays
namespace Kudvenkat.CSharp
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20);
            // AddNumbers(10, 20, new int[] { 30, 40});
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
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

