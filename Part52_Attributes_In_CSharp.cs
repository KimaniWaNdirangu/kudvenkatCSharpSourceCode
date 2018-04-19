using System;
using System.Collections.Generic;

// Part 52 - Attributes in C#

public class Program
{
    private static void Main()
    {
        Calculator.Add(10, 20); // Compiler Error : 'Calculator.Add(int, int)' is obsolete: 'Use Add(List<int> Numbers) Method'

        Calculator.Add(new List<int>() { 10, 20, 40 });
    }
}

public class Calculator
{
    [ObsoleteAttribute("Use Add(List<int> Numbers) Method", true)]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int number in Numbers)
        {
            Sum = Sum + number;
        }
        return Sum;
    }
}



