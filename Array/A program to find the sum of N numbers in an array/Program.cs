using System;

namespace A_program_to_find_the_sum_of_N_numbers_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }
            foreach (int i in num)
            {
                sum = sum + i;
            }
            Console.WriteLine("total number of Array : {0}", sum);
            Console.ReadLine();
        }
    }
}
