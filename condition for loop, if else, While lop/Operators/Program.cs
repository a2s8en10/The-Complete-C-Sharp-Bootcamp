using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            i += 13;
            Console.WriteLine("Add assignment operator " +i);

            //int a = int.Parse(Console.ReadLine());
            int a = 1;
            a <<= 3;
            Console.WriteLine("Left shift assignmet operator "+ a);

            // int b= int.Parse(Console.ReadLine());
            int b = 24;
            b >>= 1;
            Console.WriteLine("Right shift assignmet operator " + b);

            int c = 57;
            c &= 17;

            Console.WriteLine("bitwise Add assignment operator " + c);

            int d = 57;
            d |= 17;

            Console.WriteLine("bitwise Add assignment operator " + d);

            int e = 57;
            e ^= 17;

            Console.WriteLine("bitwise Add assignment operator " + e);





            Console.ReadLine();
        }
    }
}
