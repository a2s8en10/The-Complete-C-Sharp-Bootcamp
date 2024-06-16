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
           
            Console.WriteLine("Enter the element of Array : ");
            for (int i = 0; i < n; i++)                 
            {
                int m = int.Parse( Console.ReadLine());
                num[i] = m;
            }

            Console.WriteLine("--------------------");

            int c = -1;  // index number print

            foreach (int i in num)
            {
                c++;
                Console.WriteLine("Element {0} : {1}", c, i);
            }

            Console.ReadLine();
        }
    }
}
