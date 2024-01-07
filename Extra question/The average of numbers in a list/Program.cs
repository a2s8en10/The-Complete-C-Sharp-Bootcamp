using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_average_of_numbers_in_a_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number of average value :");
            int value = int.Parse(Console.ReadLine());
            int[] a = new int[value];
            
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Enter the numbers:");
                int number = int.Parse(Console.ReadLine());
                a[i] = number;
            }   
            Console.WriteLine("input..");

            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
           
            //int num = 0;
            //Console.WriteLine("total number :"+num);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int sum = 0;      
            //    sum= a[i]+sum;
            //    num = sum;
            //    Console.WriteLine(a[i]);
            //}
           
            Console.ReadLine();
        }
    }
}
