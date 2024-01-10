using System;

namespace A_program_to_delete_a_specified_integer_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a]; 

            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            Console.Write("Enter the delete number : ");
            int c = int.Parse(Console.ReadLine());

            foreach (int i in num)
            {
                if (i == c)
                {
                    continue;
                }
                Console.WriteLine(i);
            }





        }
    }
}
