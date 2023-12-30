using System;
using System.Runtime.ConstrainedExecution;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the starting number : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Ending number : ");
            //int b = int.Parse(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    int c = 0;

            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            c++;
            //            break;
            //        }
            //    }

            //    if (c == 0 && i != 1)

            //        Console.Write("{0} ", i);
            //}

            Console.WriteLine("Check the nmber is prime or not prime....");
            Console.WriteLine("Enter the number");

            int e = int.Parse(Console.ReadLine());
            int j = 0;
            int m = e / 2;
            for (int i = 2; i <=m; i++)
            {

                if (e % i == 0)
                {
                    Console.WriteLine("Its not a prime :");
                    j++;
                    break;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Its a prime :", j);
            }
            Console.ReadLine();

        }


    }
}

