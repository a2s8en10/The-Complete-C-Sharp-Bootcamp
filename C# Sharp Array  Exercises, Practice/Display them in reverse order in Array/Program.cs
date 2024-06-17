using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_them_in_reverse_order_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array : ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            Console.WriteLine("Enter the Element of Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} - ",i);
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
            }

            Console.Write("The values store into the array are: ");
            foreach (int i in num)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();

            Console.Write("The values store into the array in reverse are : ");
            for(int i = n-1;i >= 0; i--)
            {
                Console.Write("{0} ", num[i]);
            }

            Console.ReadLine();

        }
    }
}
