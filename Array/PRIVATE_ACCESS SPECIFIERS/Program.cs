using System;

namespace PRIVATE_ACCESS_SPECIFIERS
{
    public class subclass
    {
        private void show1()
        {
            Console.WriteLine("Method is private");
        }
        public void show2()
        {
            subclass sub1 = new subclass();
            sub1.show1();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //subclass sub = new subclass   // create private objact 
            //sub.show1();

            subclass sub2 = new subclass();
            sub2.show2();
            Console.ReadLine();
        }
    }
}
