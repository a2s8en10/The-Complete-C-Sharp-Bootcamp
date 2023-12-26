using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_if_an_integer_is_even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int a = int.Parse(Console.ReadLine());

            if(a % 2  == 0)
            {
                Console.WriteLine("Even Number...");
            }
            else
            {
                Console.WriteLine("Odd Number..");
            }
            Console.ReadLine();
        }
    }
}
