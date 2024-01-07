using System;

namespace Area_of_cricle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of radius");
            int r = int.Parse(Console.ReadLine());
            double Area;

            Area = 3.14 * r * r;

            Console.WriteLine("Area_of_cricle {0}", Area);
            Console.ReadLine();

        }
    }
}
