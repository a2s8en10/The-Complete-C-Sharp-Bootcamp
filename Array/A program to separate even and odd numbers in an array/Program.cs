using System;

namespace A_program_to_separate_even_and_odd_numbers_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.WriteLine("Enter the number:");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] % 2 == 0)
                {
                    Console.WriteLine("Even number in an Array : {0}", num[i]);
                }
                else
                {
                    Console.WriteLine("Odd number in an Array : {0}", num[i]);
                }
            }


        }
    }
}
