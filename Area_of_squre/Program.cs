using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_squre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side of squre : ");
            double s = double .Parse(Console.ReadLine());

            double squre = s * s;

            Console.Write("Area of Squre is = " + squre);   

            Console.ReadLine();
        }
    }
}
