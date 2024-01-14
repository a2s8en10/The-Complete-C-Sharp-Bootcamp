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
            int a = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        a = num[j + 1];

                        num[j + 1] = num[j];

                        num[j] = a;
                    }
                }

            }
            Console.WriteLine("The 2nd smallest element in the array : {0}", num[1]);
        }
    }
}
