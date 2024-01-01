using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_With_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int temp = int.Parse(Console.ReadLine());

            int sum, num, g,t, count = 1, i = 0;
            g = temp;
            t = temp;
            for (int j = 1; j <=count; j++)
            {
                while (t > 0)
                {
                    count++;
                    t = t / 10;
                }
                num = temp % 10;
                sum = temp / 10;
                temp = sum;
                i = i * 10 + num;
               
            }
            if (i == g)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Is Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}