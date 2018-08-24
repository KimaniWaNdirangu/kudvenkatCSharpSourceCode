using System;
// Part 05 - Commone Operators in C
// Assignment Operator      =
// Arithmetic Operatiors    +. -, *, /, %
// Comparison Operator      ==, !=, >, >= , <=
// Conditional Operator     &&, ||
// Ternary Operator          ?:
// Null Coalescing Oerator  ??
class Program
{
    static void Main()
    {
        //int Numerator = 10;
        //int Denominator = 2;

        //int Result = Numerator / Denominator; // Division Operator
        //int Result = Numerator % Denominator; // Modulus Operator

        //Console.WriteLine("Result = {0}", Result);

        //int Number = 10;
        //int AnotherNumber = 21;

        //Exclusive AND
        //if (Number == 10 && AnotherNumber == 20)
        //{
        //    Console.WriteLine("Hello");
        //}

        //Exclusiove OR
        //if (Number == 10 || AnotherNumber == 20)
        //{
        //    Console.WriteLine("Hello");
        //}

        //Ternary Operator

        int Number = 10;

        //bool isNumber10;

        //if (Number == 10)
        //{
        //    isNumber10 = true;
        //}
        //else
        //{
        //    isNumber10 = false;
        //}

        bool isNumber10 = Number == 10 ? true : false;

        Console.WriteLine("Number == 10 is {0}", isNumber10);
    }
}


