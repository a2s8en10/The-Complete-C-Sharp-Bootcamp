using System;

namespace Greater_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                if (c < b)
                {
                    Console.WriteLine("Greater number is : b");
                }
                else
                {
                    Console.WriteLine("Greater number is : c");
                }
            }
            else if (a < c)
            {
                Console.WriteLine("Greater number is : c");
            }
            else
            {
                Console.WriteLine("Greater number is : a");
            }
            Console.ReadLine();
        }
    }
}
