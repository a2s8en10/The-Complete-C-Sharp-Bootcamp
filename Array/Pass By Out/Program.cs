using System;

namespace Pass_By_Out
{
    internal class Program
    {
        static void passbyout(out int a)
        {
            a = 15;

            Console.WriteLine("Method Value is : " + a);
        }
        static void Main(string[] args)
        {
            int value;  // not a required value initiallized in pass by out
            passbyout(out value);
            Console.WriteLine("Main value is : " + value);

            Console.ReadLine(); // output is same because out ka reference will be pass then change by value and method value 
        }
    }
}
