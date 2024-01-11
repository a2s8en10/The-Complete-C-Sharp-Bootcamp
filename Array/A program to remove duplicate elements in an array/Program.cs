using System;
using System.Drawing;

namespace A_program_to_remove_duplicate_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int a = int.Parse(Console.ReadLine());

            int[] num = new int[a];

            Console.WriteLine("Enter the element : ");
            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }
            Array.Sort(num);
            int j = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] != num[i + 1])
                {
                    num[j++] = num[i];
                }
            }
            num[j++] = num[num.Length - 1];

            Console.WriteLine("After removing duplicate element from array:");

            for (int i = 0; i < j; i++)
                 Console.Write(" " + num[i]);


        }
    }
}
