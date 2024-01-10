using System;

namespace A_program_to_sort_the_elements_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenfth of Array :");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.WriteLine("Enter the number :");
            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }
            Array.Sort(num);
            Console.WriteLine("sort the elements of an array.....");

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }




        }
    }
}
