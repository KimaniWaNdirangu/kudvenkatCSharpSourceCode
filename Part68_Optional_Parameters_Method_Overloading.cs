using System;

// Part 68 - Optional Parameteres - Method Overloading
namespace Kudvenkat
{
    class Program
    {
        public static void Main()
        {
            AddNumbers(10, 20, new int[] { 30, 40 });
        }

        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }              
            }

            Console.WriteLine("Result = " + result);
        }
    }
}

