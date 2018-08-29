using System;
// 22 - Method Hiding in C#

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{

}

public class PartTimeEmployee : Employee
{
    // Method Hiding
    public new void PrintFullName()
    {
        //base.PrintFullName();
        //Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}
class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        
        FTE.FirstName = "Full Time";
        FTE.LastName = "Employee";
        FTE.PrintFullName();

        //PartTimeEmployee PTE = new PartTimeEmployee();
        //PTE.FirstName = "Part Time";
        //PTE.LastName = "Employee";
        //PTE.PrintFullName();
        //Type Casting
        //((Employee)PTE).PrintFullName();

        // Parent Class Reference Variable can point to a Child Class Object
        // ! Child Class Reference Variable CANNOT point to Parent Child Object
        Employee PTE = new PartTimeEmployee();
        PTE.FirstName = "Part Time";
        PTE.LastName = "Employee";

        PTE.PrintFullName();
    }
}

