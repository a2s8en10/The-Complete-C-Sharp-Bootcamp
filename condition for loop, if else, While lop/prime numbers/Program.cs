using System;
using System.Runtime.ConstrainedExecution;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting number : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Ending number : ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)    // starting to Ending 
            {
                int c = 0;

                for (int j = 2; j <= i-1; j++)  // Check the prime or not 
                {
                    if (i % j == 0)
                    {
                        c++;
                        break;
                    }
                }

                if (c == 0)

                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Check the number is prime or not prime....");
            Console.WriteLine("Enter the number");

            int e = int.Parse(Console.ReadLine());
            int h = 0;

            for (int i = 2; i <= e - 1; i++)
            {

                if (e % i == 0)
                {
                    h++;
                }
            }
            if (h == 0)
            {
                Console.WriteLine("Its a prime ");
            }
            else
            {
                Console.WriteLine("Its not a prime");
            }
            Console.ReadLine();

        }


    }
}

