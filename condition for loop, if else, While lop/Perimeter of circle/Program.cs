using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius : ");
            double Radius = double .Parse(Console.ReadLine());

            double Perimeter = 2 * 3.14 * Radius;
            Console.Write("perimeter of circle = " + Perimeter);
             
            Console.ReadLine(); 
                 

        }
    }
}
