using System;
// 16 - Methods in C#

class Program
{
    public static void Main()
    {
        //Program p = new Program();
        //p.EvenNumbers();

        Program.EvenNumbers(30); // EvenNumbers is a static method

        Program p = new Program();
        int Sum = p.Add(10, 20);

        Console.WriteLine("Sum = {0}", Sum);
    }

    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers(int Target)
    {
        int Start = 0;

        while (Start <= Target)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }
    }

    //public static void EvenNumbers()
    //{
    //    int Start = 0;

    //    while(Start <= 20)
    //    {
    //        Console.WriteLine(Start);
    //        Start = Start + 2;
    //    }
    //}
}


