using System;

// Part 49 - Access Modifiers in C# - Pulbic, Private and Protected
public class Customer
{
    protected int ID;

    #region Public and Private Members
    //private int _id;

    //public int ID
    //{
    //    get
    //    {
    //        return _id;
    //    }
    //    set
    //    {
    //        _id = value;
    //    }
    //}
    #endregion
} // End class Customer

public class CorporateCustomer : Customer
{
    public void PrintID()
    {
        CorporateCustomer CC = new CorporateCustomer();
        CC.ID = 101;

        //base.ID; // To access Base Class Protected Member ID
        //this.ID; // To access Base Class Protected Member ID
    }
}

public class Program
{
    private static void Main()
    {
        Customer C1 = new Customer();
        //Console.WriteLine(C1._id); // Compiler Error : 'Customer._id' is inaccessible due to its protection level
        //Console.WriteLine(C1.ID); // No Compiler Error - ID is a public field hence no restrictions

    }
}

