using System;
using System.Collections.Generic;

// Part 74 - List Collection Class
namespace Kudvenkat.CSharp
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            List<Customer> customers = new List<Customer>(2);

            customers.Insert(0, customer3); // Index 0
            customers.Add(customer1);       // Index 1
            customers.Add(customer2);       // Index 2
            customers.Add(customer3);       // Index 3


            //SavingsCustomer sc = new SavingsCustomer();
            //customers.Add(sc);

            //foreach(Customer c in customers)
            //{
            //    Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", c.ID, c.Name, c.Salary);

            //    Console.WriteLine("===============================================================");
            //}

            //for(int i = 0; i < customers.Count; i++)
            //{
            //    Customer c = customers[i];

            //    Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", c.ID, c.Name, c.Salary);

            //    Console.WriteLine("===============================================================");
            //}

            Console.WriteLine(customers.IndexOf(customer3, 1, 4));

        } // End Main() Method
    } // End Class Program

    public class Customer
    {
        public int    ID     { get; set; }
        public string Name   { get; set; }
        public int    Salary { get; set; }
    }

    public class SavingsCustomer : Customer
    {

    }
}

