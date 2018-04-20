using System;
using System.Reflection;

namespace Pragim
{
    // Part 53 - Reflection in C#

    public class Program
    {
        private static void Main()
        {
            //Type T = Type.GetType("Pragim.Customer");
            Type T = typeof(Customer);
            //Customer C1 = new Customer();
            //C1.GetType();

            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);

            Console.WriteLine(); // Blank Line For Readability

            Console.WriteLine("Properties in Customer Class");

            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine(); // Blank Line For Readability

            Console.WriteLine("Methods in Customer Class");

            MethodInfo[] methods = T.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+ " " + method.Name);
            }

            Console.WriteLine(); // Blank Line For Readability

            Console.WriteLine("Constructors in Customer Class");

            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    } // End class Customer
}


