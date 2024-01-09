using System;

namespace A_program_to_print_the_frequency_of_all_numbers_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.WriteLine("Enter the number:");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }
            Array.Sort(num);
            int externalCount=0;
            for (int i = externalCount; i < num.Length; i++)
            {
                int count = 1;
                
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[externalCount] == num[j])
                    {
                        count++;
                    }
                }
                externalCount=count;
                Console.WriteLine("The frequency of all numbers in an array {0} = {1}", num[i], count);

            }
        }
    }
}
