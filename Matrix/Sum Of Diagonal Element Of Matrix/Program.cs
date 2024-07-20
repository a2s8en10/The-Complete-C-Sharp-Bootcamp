using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Diagonal_Element_Of_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Order of the Matrix : ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[10, 10];

            // input 
            Console.Write("\nEnter The Matrix Elements : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            // Print 
            Console.WriteLine("Matrixs .....");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            int row = 0, col = 0;
            int sum = 0;

            while (row < m) 
            {
                if (row == col)
                {
                    sum = sum + A[row, col];
                    col++;
                }
                row++;
            }

            Console.WriteLine("Sum Of Diagonal Element Of Matrix : {0}",sum );


            Console.ReadLine();


        }
    }
}
