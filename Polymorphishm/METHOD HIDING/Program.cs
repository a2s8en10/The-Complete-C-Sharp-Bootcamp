using System;

namespace METHOD_HIDING
{
    internal class Program
    {
        class baseclass
        {
            public void show()
            {
                Console.WriteLine("Baseclass invoke!");
            }
        }

        class deriveclass : baseclass
        {
            public new void show() // use "new" keyword because hiding the baseclass property  
            {
                //base.show();
                Console.WriteLine("Deriveclass invoke!");
            }
        }
        static void Main(string[] args)
        {
            //deriveclass d = new deriveclass();
            //d.show();  // output is drive class code 

            // # different way call baseclass
            //  1.base keyword - in deriveclass method 
            //  2.((baseclass)d).show;
            //  3.baseclass bc = new deriveclass();
            //    bc.show();

            //deriveclass d = new deriveclass();
            //((baseclass)d).show();

            //baseclass bc = new deriveclass();
            //bc.show();

            Console.ReadLine();
        }
    }
}
