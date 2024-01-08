using System;

namespace A_program_to_print_array_elements_in_reverse_order_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array :");
            int a = int.Parse(Console.ReadLine());

            int[] num = new int[a];
            Console.WriteLine("Enter the number :");
            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            Console.WriteLine("Array elements in reverse order ....");
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }
    }
}
