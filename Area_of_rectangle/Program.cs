using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length : ");
            double l = double.Parse(Console.ReadLine());

            Console.Write("Enter the width : ");
            double w = double.Parse(Console.ReadLine());

            double Rectangle = l * w;

            Console.Write("Area of rectangle is = " +  Rectangle);

            Console.ReadLine();


        }
    }
}
