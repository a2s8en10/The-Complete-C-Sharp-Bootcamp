using System;

namespace Diomond_pattren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            int a = num/2 + 1;
            int spc = a ;

            for (int i = 1; i <= a; i++)
            {
                for (int k = spc; k >= 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i-1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                spc--;
            }

            int b = a;
            for (int i = 1; i <= a; i++)
            {
                for (int k = b; k <= a; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= a; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                b--;
            }
        }
    }
}

//intput = 5;
//output = 

//      *
//     * *
//    * * *
//     * *
//      *