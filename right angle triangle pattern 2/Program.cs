using System;

namespace right_angle_triangle_pattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = i; j <= a; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

//intput is : 5
//output is : 
                //* * * * *
                //* * * *
                //* * * 
                //* *
                //*









