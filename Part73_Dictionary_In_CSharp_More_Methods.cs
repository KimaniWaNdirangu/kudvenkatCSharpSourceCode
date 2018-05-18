using System;
using System.Collections.Generic;
using System.Linq;

// Part 72 - Dictionary in C#
namespace Kudvenkat.CSharp
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID     = 101,
                Name   = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID     = 110,
                Name   = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID     = 119,
                Name   = "John",
                Salary = 3500
            };

            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;


            List<Customer> customers = new List<Customer>();

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }

            //Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            //dictionaryCustomers.Add(customer1.ID, customer1);
            //dictionaryCustomers.Add(customer2.ID, customer2);
            //dictionaryCustomers.Add(customer3.ID, customer3);

            //dictionaryCustomers.Remove(999); // No Exception thrown
            //dictionaryCustomers.Clear(); // Removes all items in the dictionary

            //Customer cust;

            //if(dictionaryCustomers.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("THe key was not found.");
            //}

            // Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count);
            // Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));
        } // End Main() Method
    } // End Class Program

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}

