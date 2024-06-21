using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_frequency_of_each_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Array Length : ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            Console.Write("Enter the Array Element : ");
            for (int i = 0; i<n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
            }

            // sort the array all Element
            //int temp = 0; 
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - 1; j++)
            //    {
            //        if (num[j] >= num[j + 1])
            //        {
            //            temp = num[j + 1];
            //            num[j + 1] = num[j];
            //            num[j] = temp;
            //        }
            //    }
            //}

            int[] arr = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int j = 1; j < n; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        arr[i] = 0 ;
                    }
                }
                if (arr[i] != 0)
                {
                    arr[i] = count;
                }
            }
            Console.WriteLine("----------------------");
            for (int i = 1; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write("{0} occurs {1} times", num[i], arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
