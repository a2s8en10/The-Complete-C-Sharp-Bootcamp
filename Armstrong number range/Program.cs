using System;

namespace Armstrong_number_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the number are check Armstrong : ");
            //int a = int.Parse(Console.ReadLine());
            //int mainA = a;
            int m = 1, n = 1000;
            int i, k, a, sum = 0;
            
            for (i = m; i <= n; i++)
            {
                a = i;
                while (a != 0)
                {
                    k = a % 10;
                    a = a / 10;
                   // a = j;
                    sum = k * k * k + sum;
                }
                if (sum == i)
                {
                    Console.WriteLine("{0} ",i);
                }
                else
                {
                    Console.WriteLine("sum != {0}",i);
                }

            }

            //if (sum == i )
            //{
            //    Console.WriteLine("{0} ", i);
            //}
            //else
            //{
            //    Console.WriteLine("This number are not Armstrong.", i);
            //}
            Console.ReadLine();

        }
    }
}
