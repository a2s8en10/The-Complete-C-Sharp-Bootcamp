﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question no. 1
            Console.WriteLine("Enter the number of table : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum;
                sum = i * a;
                Console.WriteLine("{0} X {1} = {2}", a, i, sum);
            }

            // Question no. 2
            Console.WriteLine("Enter the number of table : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <=10; j++)
                {
                    int sum;
                    sum = i * j;
                    Console.WriteLine("{0} X {1} = {2}, ",i,j,sum);

                }
                Console.WriteLine();

                //int sum1;
                //sum1 = i * n;
                //Console.WriteLine("{0} X {1} = {2}", a, i, sum1);
            }













            Console.ReadLine();
        }
    }
}
