using System;

namespace left_side__pyramid_pattren
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            int spac = 1;

            for (int i = 1; i <= a; i++)
            {
                for (int k = spac; k <= a; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= a; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                spac--;
            }
            Console.ReadLine();
        }
    }
}
