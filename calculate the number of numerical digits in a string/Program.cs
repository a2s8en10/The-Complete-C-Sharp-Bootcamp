using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_the_number_of_numerical_digits_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string value..");
            string value = Console.ReadLine();

            //Console.WriteLine(" ");
            //Console.WriteLine("Array input data...");
            //Console.WriteLine(value);

            int count = 1;
            for (int a = 1; a < value.Length; a++) 
            {
                count++;
            }
            Console.WriteLine("Number in a string : " + count);

            Console.ReadLine();
        }
    }
}
