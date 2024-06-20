using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Array Length : ");
            int n1 = int.Parse(Console.ReadLine());
            int[] num1 = new int[n1];

            Console.Write("First Array Element : ");
            for (int i = 0; i < n1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num1[i] = a;
            }

            Console.Write("Second Array Length : ");
            int n2 = int.Parse(Console.ReadLine());
            int[] num2 = new int[n2];

            Console.Write("Second Array Element : ");
            for (int i = 0; i < n2; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num2[i] = a;
            }

            int n3 = n1 + n2;             // 3rd array size
            int[] num3 = new int[n3];     // array define
            int count = 0;

            for (int i = 0; i < n1; i++)
            {
                num3[count] = num1[i];
                count++;
            }
            for (int j = 0; j < n2; j++)
            {
                num3[count] = num2[j];
                count++;
            }

            int temp;
            for (int i = 0; i < n3; i++)
            {
                for (int k = 0; k < n3 - 1; k++)
                {
                    if (num3[k] >= num3[k + 1])
                    {
                        temp = num3[k + 1];
                        num3[k + 1] = num3[k];
                        num3[k] = temp;
                    }
                }
            }
            Console.WriteLine("-----------------------------------");

            foreach (int i in num3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
