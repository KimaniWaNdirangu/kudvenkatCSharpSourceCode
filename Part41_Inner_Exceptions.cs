using System;
using System.IO;

// Part 41 - Inner Exceptions
class Program
{
    static void Main()
    {
        try
        {
            try
            {
                Console.Write("Enter the first number : ");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number : ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;

                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"C:\Sample Files\Log.txt";

                if (File.Exists(filePath))
                {

                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a problem, please try later...");
                }
                else
                {
                    throw new FileNotFoundException(filePath + " is not present", ex);
                }
            }
        } // End outer try block
        catch(Exception exception)
        {
            Console.WriteLine("Current Exception = {0}", exception.GetType().Name);

            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }
        }
    } // End Main Method
}