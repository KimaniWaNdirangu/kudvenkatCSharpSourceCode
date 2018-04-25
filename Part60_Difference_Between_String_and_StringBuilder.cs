using System;
using System.Text;

// Part 60 - Difference between String and StringBuilder
namespace Pragim
{
    public class MainClass
    {
        public static void Main()
        {
            StringBuilder userString = new StringBuilder("C#");
            
            userString.Append(" Video");
            userString.Append(" Tutorial");
            userString.Append(" for");
            userString.Append(" Beginners");
            Console.WriteLine(userString.ToString());

            string userString = string.Empty;

            for (int i = 1; i <= 10000; i++)
            {
                userString += i.ToString() + " ";
            }
            Console.WriteLine(userString);
        }
    }
}

