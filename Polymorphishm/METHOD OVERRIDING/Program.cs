using System;

namespace METHOD_OVERRIDING
{
    class parant // parant class use the VIRTUAL keyword with METHOD_OVERRIDING
    {
        public virtual void show ()
        {
            Console.WriteLine("parant class method !");
        }
    }
    class child : parant    // child class use the OVERRIDING keyword with METHOD_OVERRIDING
    {
        public override void show ()
        {
            Console.WriteLine("child class method !");  // CALL PARANT CLASS { base.show() }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            child p = new child ();   // USE ANY METHOD CALL PARANT CLASS WITH OBJECT 
            ((parant)p).show ();      // RESULT ONLY CHILD CLASS BECAUSE METHOD OVERRIDING
            Console.ReadLine ();
        }
    }
}
