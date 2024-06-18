using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_all_unique_elements_in_an_array
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
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                    }
                }
            }
            sum = n - (count * 2);
            Console.WriteLine("Total number of unique elements found in the array is :{0}", sum);
            Console.ReadLine();
        }
    }
}
