using System;

namespace A_program_to_find_the_2nd_smallest_element_in_the_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int c = int.Parse(Console.ReadLine());
            int[] num = new int[c];

            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }
            Array.Sort(num);
            Console.WriteLine("The 2nd smallest element in the array : {0}", num[1]);
        }
    }
}
