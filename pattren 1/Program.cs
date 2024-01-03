using System;

namespace pattren_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int a = int.Parse(Console.ReadLine());

            int row = 1;//  i is doneted by ROW
            while (row <= a)
            {
                int col = 1; // j is doneted by COLOUM 
                while (col <= row)
                {
                    Console.Write("*");
                    col = col + 1;
                }
                Console.WriteLine();
                row = row + 2;
            }
        }
    }
}
