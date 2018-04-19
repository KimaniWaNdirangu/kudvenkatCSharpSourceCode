using System;

// Part 48 - Difference Between Types and Type Members and Regions
public class Customer
{
    #region Fields
    private int _id;
    private string _firstName;
    private string _lastName;
    #endregion

    #region Properties
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    #endregion

    #region Methods
    public string GetFullName()
    {
        return this._firstName + " " + this._lastName;
    }
    #endregion

} // End class Customer

public class Program
{
    public static void Main()
    { 
    }
}

