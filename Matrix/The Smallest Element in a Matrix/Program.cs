using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Smallest_Element_in_a_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Order Of Array : ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] num = new int[10,10];

            Console.Write("Enter The Array Element : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    num[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Matrix.....");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {   
                    Console.Write(num[i, j]+ " ");
                }
                Console.WriteLine();
            }

            int[,] small = new int[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
