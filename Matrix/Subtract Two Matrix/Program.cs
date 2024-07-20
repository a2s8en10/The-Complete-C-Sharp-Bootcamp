using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtract_Two_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Order of the Matrix : ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[10, 10];
            int[,] B = new int[10, 10];

            // input 
            Console.Write("\nEnter The Matrix Elements A: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nEnter The Matrix Elements B: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            // Print 
            Console.WriteLine("Matrixs A .....");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrixs B.....");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] C = new int[10, 10];
            Console.WriteLine("Subtract Matrix A - B : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
            Console.WriteLine("Subtract Two Matrices....");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
