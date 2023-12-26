using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_number_of_numerical_digits_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string str = Console.ReadLine();

            int count = 0 ;

            for (int i = 0; i < str.Length; i++) 
            { 
              //  Console.WriteLine(str[i]);
                if ((str[i] >= '0') && (str[i] <= '9'))
                {
                    count++;
                }

            }
            Console.WriteLine(" the_number_of_numerical_digits_in_a_string :" + count);
            Console.ReadLine();
        }
    }
}
