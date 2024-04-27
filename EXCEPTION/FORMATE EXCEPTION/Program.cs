using System;

namespace FORMATE_EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            string number = Console.ReadLine();

            try
            {
                int num = int.Parse(number);
                Console.WriteLine(num);
            }
            catch ( FormatException ex )
            {
                Console.WriteLine("string formate is invailid...");
            }
            Console.ReadLine();
        }
    }
}
