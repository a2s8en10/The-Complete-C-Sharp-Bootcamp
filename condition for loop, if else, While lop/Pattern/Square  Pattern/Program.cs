using System;

namespace Square__Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
// 5 x 5
// * * * * *
// * * * * *
// * * * * *
// * * * * *
// * * * * *
