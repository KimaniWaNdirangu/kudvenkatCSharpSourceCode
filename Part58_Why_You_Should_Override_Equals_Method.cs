using System;
using System.Text;

// Part 58 - Why you should override Equals Method
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";

            //Customer C2 = C1;

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));

            //int i = 10;
            //int j = 10;

            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            //Direction direction1 = Direction.East;
            //Direction direction2 = Direction.West;

            //Console.WriteLine(direction1 == direction2);
            //Console.WriteLine(direction1.Equals(direction2));
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }

    //public enum Direction
    //{
    //    East = 1,
    //    West = 2,
    //    North = 3,
    //    South = 4
    //}
}

