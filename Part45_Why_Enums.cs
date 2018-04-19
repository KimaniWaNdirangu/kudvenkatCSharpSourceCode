using System;

// Part 45 - Why Enums
public class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];

        customers[0] = new Customer
        {
            Name = "Mark",
            Gender = 1
        };

        customers[1] = new Customer
        {
            Name = "Mary",
            Gender = 2
        };

        customers[2] = new Customer
        {
            Name = "Sam",
            Gender = 0
        };

        foreach(Customer customer in customers)
        {
            Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
        }
    }

    public static string GetGender(int gender)
    {
        switch (gender)
        {
            case 0:
                return "Unknown";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Invalid data detected";
        }
    } // End method GetGender
}
// 0 - Unknown
// 1 - Male
// 2 - Female
public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }
}