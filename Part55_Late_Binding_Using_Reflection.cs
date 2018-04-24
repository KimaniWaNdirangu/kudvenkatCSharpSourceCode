using System;
using System.Reflection;

// Part 55 - Late Bindiing using Reflection in C#

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("Pragim.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];

            parameters[0] = "Pragim";
            parameters[1] = "Technologies";

            string FullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name = {0}", FullName);

            //Customer C1 = new Customer();
            //string FullName = C1.GetFullName("Pragim", "Tech");

            //Console.WriteLine("Full Name = {0}", FullName);
        }
    }

    public class Customer
    {
       public string GetFullName(string FirstName, string LastName)
       {
           return FirstName + " " + LastName;
       }
    }
}


