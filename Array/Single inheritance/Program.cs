using System;

namespace Single_inheritance
{
    class baseclass
    {
        public void show1()
        {
            Console.WriteLine("this is base class....");
        }
    }

    class driveclass : baseclass // this is the single inheritance 
    {
        public void show2()
        {
            Console.WriteLine("this is drive class....");
        }
    }
    internal class Programs
    {
        static void Main(string[] args)
        {
            driveclass sub = new driveclass();
            sub.show1();
            sub.show2();
            Console.ReadLine();s
        }
    }
}
