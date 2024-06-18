using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_the_elements_of_one_array_into_another_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array Length : ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            Console.Write("Array Element : ");
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
            }
            Console.WriteLine("The elements stored in the first array are :");
            foreach (int i in num)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine("\n");

            Console.WriteLine("The elements stored in the second array are :");
            foreach (int i in num)
            {
                Console.Write("{0} ",i);
            }

            Console.ReadLine();
        }
    }
}
