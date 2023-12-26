
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_____3_largest_number_of_array
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

            Console.WriteLine("  ");
            Console.WriteLine(" input data.... ");
            foreach (int item in numbers1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" 3 Largest number of Array : ");

            Array.Sort(numbers1);  // important point S
        
            Console.WriteLine(numbers1[num-1]);
            Console.WriteLine(numbers1[num-2]);
            Console.WriteLine(numbers1[num-3]);

            Console.WriteLine(" ");
            Console.WriteLine(" 3 Smallest number of Array : ");

            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers1[1]);
            Console.WriteLine(numbers1[2]);
           

            Console.ReadLine();

        }
    }
}
