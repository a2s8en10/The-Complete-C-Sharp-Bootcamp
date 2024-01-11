using System;
using System.Runtime.InteropServices;

namespace A_program_to_count_distinct_elements_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lrngth of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.WriteLine("Enter the number :");
            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            int count = 1;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] != num[j])
                    {
                        count++;
                    }

                }
            }
            Console.WriteLine("count distinct elements of an array : {0}", count);

        }
    }
}
