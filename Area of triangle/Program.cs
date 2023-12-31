using System;

namespace Area_of_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of triangle : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter the height of base : ");
            int b = int.Parse(Console.ReadLine());

            int Area;

            Area = h * b / 2;

            Console.WriteLine("Area of triangle {0}", Area);
            Console.ReadLine();
        }
    }
}
