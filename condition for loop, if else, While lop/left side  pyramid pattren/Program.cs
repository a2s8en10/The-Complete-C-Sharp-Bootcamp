using System;

namespace left_side__pyramid_pattren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
           
            int a = int.Parse(Console.ReadLine());

            /*int a = 5;*/
            int s = a / 2 + 1;

            for (int i = 1; i <= s; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= s; i++)
            {
                for (int j = i; j <= s - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
