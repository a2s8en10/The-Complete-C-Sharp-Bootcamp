using System;

namespace A_program_to_separate_even_and_odd_position_numbers_in_an_array_
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

            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (i == count)
                {
                    Console.WriteLine("Even position numbers in an array : {0}", num[i]);
                    count = count + 2;
                }
                else
                {
                    Console.WriteLine("Odd position numbers in an array : {0}", num[i]);
                }
            }



        }
    }
}
