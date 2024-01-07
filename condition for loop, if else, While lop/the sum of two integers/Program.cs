using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_sum_of_two_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the_sum_of_two_integers");
            Console.WriteLine();

            Console.WriteLine("Enter the first number :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("sum number = {0}",sum);

            Console.WriteLine("----------------------------");

            Console.WriteLine("the_sum_of_two_string");
            Console.WriteLine();
            Console.WriteLine("Enter the first string :");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the second string :");
            string str1 = Console.ReadLine();

            string add = str + str1;
            Console.WriteLine("sum string = {0}", add);
            Console.ReadLine();
        }
    }
}
