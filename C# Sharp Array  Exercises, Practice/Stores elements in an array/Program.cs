using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
           
            Console.WriteLine("--------------------");
            for (int i = 0; i < n; i++)                 
            {
                Console.Write("Element {0} : ",i);
                int m = int.Parse( Console.ReadLine());
                num[i] = m;
            }

            Console.Write("Elements in array are: ");
            foreach (int i in num)
            {
                Console.Write("{0} ",i);
            }

            Console.ReadLine();
        }
    }
}
