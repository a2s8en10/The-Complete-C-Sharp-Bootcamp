using System;

namespace SEALED_CLASS
{
    sealed class parant  // sealed class are not inherit
    {
        public void show()
        {
            Console.WriteLine("parant class invoke !");
        }
    }
    //class child : parant
    //{
    //    public void show1()
    //    {
    //        Console.WriteLine("Child class invoke !");
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //child c = new child();
            //c.show();
            
            parant p = new parant();
            p.show();
            Console.ReadLine();
        }
    }
}
