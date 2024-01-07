using System;
using System.Runtime.Versioning;

namespace Factorial_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int a = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 1; i <= a; i++)
            {
                sum = i * sum;
            }
            Console.WriteLine("Factorial number is {0}", sum);
            Console.ReadLine();
        }
    }
}
