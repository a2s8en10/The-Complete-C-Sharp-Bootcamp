using System;

namespace A_program_to_check_if_two_arrays_are_the_same_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of First Array : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of second Array : ");
            int b = int.Parse(Console.ReadLine());

            int[] num1 = new int[a];
            int[] num2 = new int[b];

            Console.WriteLine("Enter the first Array Element : ");
            for (int i = 0; i < num1.Length; i++)
            {
                int k = int.Parse(Console.ReadLine());
                num1[i] = k;
            }

            Console.WriteLine("Enter the second Array element : ");
            for (int i = 0; i < num2.Length; i++)
            {
                int p = int.Parse(Console.ReadLine());
                num2[i] = p;
            }

            if (num1.Length == num2.Length)
            {
                if (num1 == num2)
                {
                    Console.WriteLine("same...");
                }
                else
                {
                    Console.WriteLine("Not same...");
                }
            }
            else
            {
                Console.WriteLine("Array Length are not Equal..");
            }
        }
    }
}
