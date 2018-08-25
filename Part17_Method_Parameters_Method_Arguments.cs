using System;
// 17 - Method Parameters & Method Arguments in C#

class Program
{
    #region Parameter Arrays

    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        //ParamsMethod();
        //ParamsMethod(Numbers);
        ParamsMethod(1, 2, 3, 4, 5);
    }

    // Method Parameters - Parameter Arrays
    // public static void ParamsMethod(params int[] Numbers, params string[] Names) // Illegal
    // public static void ParamsMethod(params int[] Numbers, int x) // Illegal
 
    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements.", Numbers.Length);

        foreach(int i in Numbers)
        {
            Console.WriteLine(i + " ");
        }
    }
    #endregion

    #region Out Parameters
    //public static void Main()
    //{
    //    int Total = 0;
    //    int Product = 0;

    //    Calculate(10, 20, out Total, out Product);

    //    Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
    //}

    //// Out Parameters
    //public static void Calculate(int FN, int SN, out int Sum, out int Product)
    //{
    //    Sum = FN + SN;
    //    Product = FN * SN;
    //}
    #endregion

    #region Reference Parameters
    //public static void Main()
    //{
    //    int i = 0;

    //    SimpleMethod(ref i);

    //    Console.WriteLine("Pass By Reference : i = {0}", i);
    //}

    //// Pass By Reference
    //public static void SimpleMethod(ref int j)
    //{
    //    j = 101;
    //}
    #endregion

    #region Value Parameters
    //public static void Main()
    //{
    //int i = 0;

    // SimpleMethod(i); // Pass By Value

    //Console.WriteLine("Pass By Value : i = {0}", i);
    //}

    // Pass By Value
    //public static void SimpleMethod(int j)
    //{
    //    j = 101;
    //}
    #endregion
}


