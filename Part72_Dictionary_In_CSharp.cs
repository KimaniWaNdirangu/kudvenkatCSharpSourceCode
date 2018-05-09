using System;
using System.Collections.Generic;

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

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            if (dictionaryCustomers.ContainsKey(135))
            {
                Customer cust = dictionaryCustomers[135];
            }


            if (! dictionaryCustomers.ContainsKey(customer1.ID))
            {
                dictionaryCustomers.Add(customer1.ID, customer3);
            }
            // dictionaryCustomers.Add(customer3.ID, customer3); // Causes a Runtime Exception

            Customer customer119 = dictionaryCustomers[119];

            foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            {
                //Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                //Customer cust = customerKeyValuePair.Value;
                //Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", cust.ID, cust.Name, cust.Salary);
                //Console.WriteLine("--------------------------------------------------------");
            }

            // Retrieve Keys Only
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("-----------------------------------------------");
            // Retrieve Values Only
            foreach (Customer customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            // Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);
        } // End Main() Method
    } // End Class Program

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}

