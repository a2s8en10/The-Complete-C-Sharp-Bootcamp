using System;

namespace pattren_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number :");
            n = int .Parse(Console.ReadLine());

            int i = 2;//row
            while (i <= n)

            {
                int j = 1; // col
                while (j <= i)

                {
                    Console.Write("* ");
                    j = j + 1;
                }

                Console.WriteLine();
                i = i + 2;
            }
        }
    }
}

//Enter the number :
//7
//**
//****
//******
