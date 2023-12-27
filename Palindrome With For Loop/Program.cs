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
            int temp = 123;
            int sum, num,i = 0;

            for (int j = 1; j <= 3; j++)
            {
                num = temp % 10;
                sum = temp / 10;
                temp = sum;
                i = i * 10 + num;
            }
            if (i == temp)
            {
                Console.WriteLine("Is Not Palindrome : {0}", i);
            }
            else
            {
                Console.WriteLine("Is Palindrome : {0}",i);
            }
            Console.ReadLine();
        }
    }
}