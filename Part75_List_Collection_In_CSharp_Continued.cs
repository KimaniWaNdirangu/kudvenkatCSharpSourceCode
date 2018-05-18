using System;
using System.Collections.Generic;
using System.Linq;

// Part 75 - List Collection Class Continued
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
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            //Customer[] customerArray = new Customer[3];

            //customerArray[0] = customer1;
            //customerArray[1] = customer2;
            //customerArray[2] = customer3;

            List<Customer> listCustomers = new List<Customer>();

            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Dictionary<int, Customer> dictionaryCustomers = listCustomers.ToDictionary(x => x.ID);

            foreach (KeyValuePair<int, Customer> kvp in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", c.ID, c.Name, c.Salary);
            }

            //foreach (Customer  c in listCustomers)
            //{
            //    Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            //List<Customer> listCustomers = new List<Customer>();

            //listCustomers.Add(customer1);       
            //listCustomers.Add(customer2);       
            //listCustomers.Add(customer3);

            // FindIndex() Function

            // int index = listCustomers.FindIndex(cust => cust.Salary > 5000);

            // int index = listCustomers.FindIndex(2, cust => cust.Salary > 5000);

            //int index = listCustomers.FindLastIndex(cust => cust.Salary > 5000);

            //Console.WriteLine("Index = " + index);


            // Find() Function
            // Customer c = listCustomers.Find(cust => cust.Salary > 5000); // Returns a Customer Object

            // FindLast() Function
            // Customer c = listCustomers.FindLast(cust => cust.Salary > 5000); // Returns the Last Customer Object

            // FindAll() Function

            // List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 5000); // Returns the Last Object

            //foreach (Customer c in customers)
            //{
            //    Console.WriteLine("ID = {0} && Name = {1} && Salary = {2}", c.ID, c.Name, c.Salary);
            //}

            // Exists() Function

            //if(listCustomers.Exists(cust => cust.Name.StartsWith("x")))
            //{
            //    Console.WriteLine("Customer with name starting with 'P' exists in the list.");
            //}
            //else
            //{
            //    Console.WriteLine("Customer with name starting with 'x' does not exists in the list..");
            //}

        } // End Main() Method
    } // End Class Program

    public class Customer
    {
        public int    ID     { get; set; }
        public string Name   { get; set; }
        public int    Salary { get; set; }
    }
}

