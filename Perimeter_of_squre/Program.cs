using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_of_squre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side of square : ");
            double s = double.Parse(Console.ReadLine());

            double square = 4 * s;

            Console.Write("perimeter of sqaure is = " + square);
            Console.ReadLine();
        }
    }
}
