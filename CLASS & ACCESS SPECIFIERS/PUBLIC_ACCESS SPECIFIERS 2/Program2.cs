using ACCESS_SPECIFIERS_1;
using System;

namespace ACCESS_SPECIFIERS_2
{
    internal class Program2 : info 
    {
        static void Main(string[] args)
        {
            //info sub = new info();
            //sub.show1();

            Program2 sub1 = new Program2();
            sub1.show1();


            Console.ReadLine();
        }
    }
}
