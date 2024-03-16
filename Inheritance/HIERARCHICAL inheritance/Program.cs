using System;

namespace HIERARCHICAL_inheritance
{
    class baseclass
    {
        public void show1()
        {
            Console.WriteLine("base class");
        }
    }
    class driveclass1 : baseclass 
    {
        public void show2()
        {
            Console.WriteLine("drive 1 class");
        }
    }
    class driveclass2 : baseclass
    {
        public void show3()
        {
            Console.WriteLine("drive 2 class");
        }
    }
    class driveclass3 : baseclass
    {
        public void show4()
        {
            Console.WriteLine("drive 3 class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //driveclass1 sub = new driveclass1();
            //sub.show1();
            //sub.show2();
            //driveclass2 sub2 = new driveclass2();
            //sub2.show3();
            driveclass3 sub3 = new driveclass3();
            sub3.show1 ();
            sub3.show4();
            
        }
    }
}
