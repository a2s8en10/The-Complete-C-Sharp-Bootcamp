using System;

namespace Array_swapping_method
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
            int k;
            int temp;
            Console.WriteLine("Array elements in reverse order using the swapping method....");
            for (int j = 1; j <= num.Length; j++)
            {
                k = num.Length - j;
                temp = num[k];
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
