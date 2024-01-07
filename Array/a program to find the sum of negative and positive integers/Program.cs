using System;

namespace a_program_to_find_the_sum_of_negative_and_positive_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter the length of Array : ");
            int a = int .Parse(Console.ReadLine());

            int[] num = new int[a];
            Console.WriteLine("Enter the number ");

            for (int i = 0; i < num.Length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                num[i] = n;
            }

            foreach (int item in num)
            {
                sum = sum + item;
            }

            if (sum >= 0)
            {
                Console.WriteLine("positive integers : {0}", sum);
            }
            else
            {
                Console.WriteLine("negetive integers : {0}", sum);
            }

            Console.ReadLine();
        }
    }
}
