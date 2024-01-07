using System;

namespace Fabonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            int num = 0, sum = 0;
            // int num = 0;
            int temp = 1;
            Console.Write("Fabonacci series is :"+num);
            for (int i = 0; i < n; i++)
            {
                sum = num + temp;
                num = temp;
                temp = sum;

                Console.Write(" {0}", num);
            }
            Console.ReadLine();

        }
    }
}
