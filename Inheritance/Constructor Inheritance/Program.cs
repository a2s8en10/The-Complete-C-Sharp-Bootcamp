using System;

namespace Constructor_Inheritance
{
    class baseclass
    {
        public baseclass(string name) 
        {
            Console.WriteLine(name);
        }
    }
    class deriveclass : baseclass
    {
        public deriveclass() : base ("Anurag")
        {
            Console.WriteLine("This is deriveclass contructor...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            deriveclass anu = new deriveclass();
            Console.ReadLine();
        }
    }
}
