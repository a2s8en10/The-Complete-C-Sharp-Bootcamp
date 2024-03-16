using System;

namespace Multi_level_inheritance
{
    class baseclass
    {
        public void show1()
        { 
            Console.WriteLine("base class");
        }
    }
    class intermediateclass : baseclass 
    {
        public void show2()
        {
            Console.WriteLine("intermediate class");
        }

    }
    class driveclass1 : intermediateclass
    { 
        public void show3()
        {
            Console.WriteLine("drive class");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //baseclass sub = new baseclass();
            //sub.show1();

            //intermediateclass sub1 = new intermediateclass();
            //sub1.show1();
            //sub1.show2();

            //driveclass1 sub3 = new driveclass1();
            //sub3.show1();
            //sub3.show2();
            //sub3.show3();

            driveclass2 sub3 = new driveclass2();
            sub3.show1();
            sub3.show2();
            sub3.show3();
            sub3.sub();
            Console.ReadLine();
        }
    }
}
