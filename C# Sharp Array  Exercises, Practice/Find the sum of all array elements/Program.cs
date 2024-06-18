using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_sum_of_all_array_elements
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

            int sum = 0;
            for (int i = 0;i < n; i++)
            {
                sum = sum + num[i];
                //sum += num[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is : {0}",sum);

            Console.ReadLine();
        }
    }
}
