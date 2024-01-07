using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_tringle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the higth : ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Enter the base : ");
            double b = double.Parse(Console.ReadLine());

            double Area = (h * b) / 2;
            Console.Write("Area of tringle = " +  Area);

            Console.ReadLine();



        }
    }
}
