using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_2D_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the Order of the Matrix : ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter the Order of the Matrix : [{0} , {1}]",m,n);
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = int.Parse(Console.ReadLine());
                    }
                }

            Console.WriteLine("\nMatrix : ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(A[i, j] + " ");

                    }
                    Console.WriteLine();
                }

                // Console.Clear();
                //Console.WriteLine("\nMatrix A : ");
                //for (int i = 0; i < m; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        Console.Write(A[i, j] + " ");

                //    }
                //    Console.WriteLine();
                //}
                //Console.WriteLine("Transpose Matrix : ");

                //for (int i  = 0; i < m; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        Console.Write(A[j, i] + " ");

                //    }
                //    Console.WriteLine();
                //}
                Console.Read();
        }
    }
}
