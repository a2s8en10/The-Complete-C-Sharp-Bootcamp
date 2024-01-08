using System;

namespace A_program_to_Print_the_Average_of_Numbers_in_array_at_an_even_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array :");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            int j = 0;
            double sum = 0;
            int count = 0;
            while (j <= (num.Length - 1))
            {
                sum = sum + num[j];
                j = j + 2;
                count++;
            }
            sum = sum / count;
            Console.WriteLine("The Average of Numbers in array at an even position : {0}", sum);
            Console.ReadLine();
        }
    }
}
