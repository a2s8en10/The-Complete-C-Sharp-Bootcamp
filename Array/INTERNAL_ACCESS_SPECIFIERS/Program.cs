using System;

namespace INTERNAL_ACCESS_SPECIFIERS
{
    public class class1
    {
        internal void show1()
        {
            Console.WriteLine("this is internal");
        }
        internal void show2()
        {
            class1 c1 = new class1();
            c1.show1();
        }

    }

    internal class Program : class1
    {
        static void Main(string[] args)
        {
            class1 c2 = new class1();
            c2.show2();

            class1 c3 = new class1();
            c3.show1();

            Program p1 = new Program();
            p1.show1();

            Console.ReadLine();
        }
    }
}
