using System;

namespace pattren_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number :");
            n = int.Parse(Console.ReadLine());
            int i = 1;//row

            while (i <= n)
            {
                int j = i; // col

                while (j <= n)
                {
                    Console.Write("* ");
                    j = j + 1;
                }
                Console.WriteLine();
                i = i + 1;
            }
            //for (int i = 0; i <=n; i++)
            //{
            //    for (int j = i; j <=n; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
//Enter the number :
//5
//*****
//****
//***
//**
//*