
using System;

namespace A_program_to_separate_positive_and_negative_numbers_in_an_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.WriteLine("Enter the number :");
            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 0)
                {
                    Console.WriteLine("positive numbers in an array : {0}", num[i]);
                }
                else
                {
                    Console.WriteLine("Negative numbers in an array : {0}", num[i]);

                }
            }
            Console.ReadLine();
        }
    }
}
