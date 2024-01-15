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

            int temp;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("sort the elements of an array : ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
