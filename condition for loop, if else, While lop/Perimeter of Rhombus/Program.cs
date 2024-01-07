using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_of_Rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the of Rhombus side : ");
            float a= float.Parse(Console.ReadLine());

            float perimeter = 4 * a;
            Console.Write("Rhombus perimeter is : " + perimeter);

            Console.ReadLine();
        }
    }
}
