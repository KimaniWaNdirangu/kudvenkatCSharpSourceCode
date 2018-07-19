using System;
//Part 06 - Nullable Types
class Program
{
    static void Main()
    {
        //bool? AreYouMajor = null;

        //if (AreYouMajor == true)
        //{
        //    Console.WriteLine("User is Major");
        //}
        //else if(!AreYouMajor == false)
        //{
        //    Console.WriteLine("User is Not Major");
        //}
        //else
        //{
        //    Console.WriteLine("User did not answer the question.");
        //}

        int? TicketsOnSale = 100;

        int AvailableTickets = TicketsOnSale ?? 0; // Null Coalescing Operator

        //if (TicketsOnSale == null)
        //{
        //    AvailableTickets = 0;
        //}
        //else
        //{
        //    AvailableTickets = (int)TicketsOnSale.Value;
        //    //AvailableTickets = TicketsOnSale.Value;
        //}
        Console.WriteLine("Available Tickets = {0}", AvailableTickets);
    }
}


