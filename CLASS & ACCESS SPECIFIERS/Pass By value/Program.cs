using System;

namespace Pass_By_value
{
    internal class Program
    {
        static void passbyvalue( int a)
        {
            a = a + 2;

            Console.WriteLine("Method Value is : "+a);
        }
        static void Main(string[] args)
        {
            int value = 3;
            passbyvalue(value);
            Console.WriteLine("Main value is : " +value);

            Console.ReadLine();
        }
    }
}
