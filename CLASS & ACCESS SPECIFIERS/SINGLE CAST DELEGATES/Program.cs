using System;

namespace SINGLE_CAST_DELEGATES
{
    public delegate void calculation(int num1,  int num2);
    internal class Program
    {
        public static void Add(int a ,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is {0}",c);
        }
        static void Main(string[] args)
        {
            calculation obj = new calculation(Add);
            obj.Invoke(10, 20);
            Console.ReadLine();
        }
    }
}
