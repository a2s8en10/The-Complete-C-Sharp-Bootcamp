using System;

namespace Pass_By_Reference
{
    internal class Program
    {
        static void passbyref( ref int a)
        {
            a = a + 15;

            Console.WriteLine("Method Value is : " + a);
        }
        static void Main(string[] args)
        {
            int value = 15;
            passbyref( ref value);
            Console.WriteLine("Main value is : " + value);

            Console.ReadLine(); // output is same because reference will be pass then change by value and method value 
        }
      
    }
}
