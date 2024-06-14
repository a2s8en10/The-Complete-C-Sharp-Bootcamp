using System;

namespace Right_side_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            int spc;
            spc = a - 1;
            for (int i = 1; i <= a; i++)
            {
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                spc--;
            }

            //for (int i = 1; i <= a; i++)
            //{
            //    for (int k = i; k <= a; k++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = i; j <= a; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    spc--;
            //}
            //Console.ReadLine();
        }
    }
}
//Enter the number : 5

//         *
//       * *
//     * * *
//   * * * *
// * * * * *