using System;
// Part 46  - Enums Example
public class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];

        customers[0] = new Customer
        {
            Name = "Mark",
            Gender = Gender.Male
        };

        customers[1] = new Customer
        {
            Name = "Mary",
            Gender = Gender.Female
        };

        customers[2] = new Customer
        {
            Name = "Sam",
            Gender = Gender.Unknown
        };

        foreach(Customer customer in customers)
        {
            Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
        }
    }

    public static string GetGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";
        }
    } // End method GetGender
}

public enum Gender
{
    Unknown,
    Male,
    Female
}

// 0 - Unknown
// 1 - Male
// 2 - Female
public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}