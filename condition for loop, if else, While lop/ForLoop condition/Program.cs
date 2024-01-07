using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());

            for(int i = 1; i <= a; i++)
            {
                int sum;
                sum = i * i * i ;

                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", i,i,sum);

            }
            Console.ReadLine();
        }
    }
}
