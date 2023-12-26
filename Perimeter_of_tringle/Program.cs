using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_of_tringle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the heigth : ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Enter the base : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the side : ");
            double s = double.Parse(Console.ReadLine());

            double p = h+b+s;

            Console.Write("Perimeter of tringle : " + p);
            Console.ReadLine();


        }
    }
}
