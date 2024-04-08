using System;

namespace SEALED_METHOD
{
    // sealed method is use because cannot create a child class and override classes
    class A
    {
        public virtual void show ()
        {
            Console.WriteLine("base class...");
        }
    }
    class B : A
    {
        public sealed override void show()
        {
            Console.WriteLine("Derive class...");
        }
    }
    //class c : B   // sealed class cannot create a child class
    //{
    //    public override void show()
    //    {
    //        Console.WriteLine("Derive class...");
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.show();
            Console.ReadLine();
        }
    }
}
