using System;

namespace A_program_to_search_a_specified_integer_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lrmgth of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            for (int i = 0; i < num.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }
            Console.Write("Enter the number : ");
            int s= int.Parse(Console.ReadLine());

            for (int i = 0; i < num.Length; i++) 
            {
                if (num[i] == s)
                {
                    Console.WriteLine("search a specified integer in an array {0}: index no. {1}", num[i],i);
                }
            }




        }
    }
}
