using System;

// Part 47 - Enums in C#
public class Program
{
    public static void Main()
    {
        Gender gender = (Gender)Season.Winter;

        //Gender gender = (Gender)3;
        //int num = (int)Gender.Unknown;
        //int num = Convert.ToInt32(Gender.Unknown);

        //short[] Values = (short[])Enum.GetValues(typeof(Gender));

        //foreach (short value in Values)
        //{
        //    Console.WriteLine(value);
        //}
        //Console.WriteLine("==============================");
        //string[] Names = Enum.GetNames(typeof(Gender));

        //foreach (string name in Names)
        //{
        //    Console.WriteLine(name);
        //}
    }
}

public enum Gender : short
{
    Unknown = 1,
    Male = 2,
    Female = 3
}


public enum Season
{
    Winter = 1,
    Spring = 2,
    Summer = 3
}
