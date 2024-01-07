
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY___the_occurrence_of_an_integer_in_the_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number of element you want to store in array ?? ");
            int num = int.Parse(Console.ReadLine());

            int[] numbers1 = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the Array value " + i);
                int value = int.Parse(Console.ReadLine());
                numbers1[i] = value;
            }

            Console.WriteLine(); // new line 

            Console.WriteLine(" input data.... ");
            foreach (int item in numbers1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter a number to check in the array: ");
            int check = int.Parse(Console.ReadLine());




            Console.ReadLine();

        }
    }
}
