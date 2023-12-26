using System;

namespace Area_of_cricle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of radius : "); 
            float r = float.Parse(Console.ReadLine());

            double Area = 3.14 * r * r;

            Console.WriteLine("Area_of_cricle = " + Area);

            Console.ReadLine();
        }
    }
}
