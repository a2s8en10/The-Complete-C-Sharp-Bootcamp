using System;

namespace right_angle_triangle_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
