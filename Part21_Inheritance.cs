using System;
// 18 - Inheritance in C#

public class Employee
{
    public string FirstName;
    public string LastName;
    public string EmailAddress;

    public Employee()
    {
        Console.WriteLine("Employee Class Constructor Called");
    }

    public Employee(string Message)
    {
        Console.WriteLine(Message);
    }

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee() : base("Derived Class Controlling Parent Class")
    {
        // Console.WriteLine("FullTimeEmployee Class Constructor Called");
    }
    public float YearlySalary;
}


//public class PartTimeEmployee : Employee
//{
//    public PartTimeEmployee()
//    {
//        Console.WriteLine("PartTimeEmployee Class Constructor Called");
//    }
//    public float HourlyRate;
//}
class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();


        //FTE.FirstName = "Pragim";
        //FTE.LastName = "Tech";
        //FTE.YearlySalary = 50000;
        //FTE.PrintFullName();

        //PartTimeEmployee PTE = new PartTimeEmployee();
        //PTE.FirstName = "Part";
        //PTE.LastName = "Time";
        //PTE.PrintFullName();

    }
}


