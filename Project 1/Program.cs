using System;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number :");
            int num1 = int .Parse(Console.ReadLine());

            Console.Write("Enter the seccond number :");
            int num2 = int .Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.Write("The sum of = " + sum );
            Console.ReadLine(); 

        }
    }
}
