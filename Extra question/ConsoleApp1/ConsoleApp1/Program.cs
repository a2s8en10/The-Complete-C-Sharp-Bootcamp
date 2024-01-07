using System;

namespace firstcode

{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter First Number : ");
            int num2 = int.Parse(Console.ReadLine());



            int sum = num1 + num2;

            Console.Write("The sum is = " + sum);
            Console.ReadLine();

        }
    }
}
