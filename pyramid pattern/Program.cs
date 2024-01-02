using System;

namespace pyramid_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            for (int i = 1; i <= a; i++)
            {
                for (int j = i; j <= a; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
