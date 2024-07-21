using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Sum_Of_Each_Row_OF_The_Matrix
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

            // Sum OF Row
            int k = 0;
            int []temp = new int[m];
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum = sum + A[i, j];
                }

                temp[k] = sum;
                k++;
                
            }
            Console.WriteLine();
            Console.Write("The Sum Of Each Row OF The Matrix : ");
            for (int i = 0;i < m; i++)
            {
                Console.Write(temp[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
