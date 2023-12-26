using System;
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

            //Console.WriteLine("Enter the number of table : ");
            //int a = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    int sum;
            //    sum = i * a;
            //    Console.WriteLine("{0} X {1} = {2}", a, i, sum);
            //}

            //// Question no. 2

            //Console.WriteLine("Enter the number of table : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 1; j <=n; j++)
            //    {
            //        int sum;
            //        sum = i * j;
            //        Console.Write("{0} X {1} = {2}, ",j,i,sum);

            //    }
            //    Console.WriteLine();

            //    //int sum1;
            //    //sum1 = i * n;
            //    //Console.WriteLine("{0} X {1} = {2}", a, i, sum1);
            //}

            //Question no. 3

            Console.WriteLine("Enter the number of Digit : ");
            int b = int.Parse(Console.ReadLine());
            int m;
            m = b * 2; 

            for (int i = 1; i <= m;) 
            {

                Console.Write("{0}, ", i);
                i = i + 2;
                //int sum;

                //num = sum + num;

                //for (int j = 1; j <= i;) 
                //{
                //    Console.Write("{0}, ", j);
                //    j = j + 2;

                //}
            }










            Console.ReadLine();
        }
    }
}
