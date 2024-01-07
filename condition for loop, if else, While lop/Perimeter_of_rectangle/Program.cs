using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length : ");
            double l = double.Parse(Console.ReadLine());

            Console.Write("Enetr the width : ");
            double w = double.Parse(Console.ReadLine());

            double Rectangle = (l * w) * 2;

            Console.Write("Perimeter of rectangle = " + Rectangle);
            Console.ReadLine();

        }
    }
}
