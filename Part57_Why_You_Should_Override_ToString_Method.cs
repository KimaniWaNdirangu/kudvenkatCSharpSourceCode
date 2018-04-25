using System;

// Part 57 - Why You Should Override ToString Method
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            int Number = 10;

            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Console.WriteLine(C1.ToString());
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + " " + this.FirstName;
        }
    }
}

