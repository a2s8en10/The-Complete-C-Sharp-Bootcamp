using System;
using System.Threading.Channels;

namespace count_number_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            int count = 0;

            while (a > 0)
            {
                count++;
                a = a / 10;
            }
            Console.WriteLine(" count_number_digits = {0}", count);
            Console.ReadLine();
        }
    }
}
