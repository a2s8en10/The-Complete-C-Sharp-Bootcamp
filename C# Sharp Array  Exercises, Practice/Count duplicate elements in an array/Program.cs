using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_duplicate_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array Length : ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            Console.Write("Array Element : ");
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
            }
            int count = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements found in the array is :{0}",count);

            Console.ReadLine();
        }
    }
}
