using System;

namespace A_Program_to_Merge_two_unsorted_arrays_of_different_lengths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array 1st :");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of array 2nd :");
            int b = int.Parse(Console.ReadLine());

            int[] num1 = new int[a];
            int[] num2 = new int[b];

            Console.WriteLine("Enter the element 1st array :");
            for (int i = 0; i < a; i++)
            {
                int c = int.Parse(Console.ReadLine());
                num1[i] = c;
            }

            Console.WriteLine("Enter the element 2nd array :");
            for (int i = 0; i < b; i++)
            {
                int d = int.Parse(Console.ReadLine());
                num1[i] = d;
            }

            int length1 = 0;
            int length2 = 0;

            foreach (int i in num1)
            {
                length1++;
            }

            foreach (int i in num2)
            {
                length2++;
            }

            int length = 0;
            length = length1 + length2;

            int[] num = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //Console.WriteLine("Merge two unsorted arrays");
            //foreach (int i in num1)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach(int i in num2)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
