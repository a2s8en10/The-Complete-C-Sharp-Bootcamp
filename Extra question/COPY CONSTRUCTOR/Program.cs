using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPY_CONSTRUCTOR
{
    class example
    {
        string name;
        int age;

        public example() { }
        public example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void getexample ()
        {
            Console.WriteLine("Name is "+ this.name);
            Console.WriteLine("age is " + this.age);
        }

        public example (example e)      // this is a copy constructor  
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getexample1()
        {
            Console.WriteLine("Your Name is " + this.name);
            Console.WriteLine("Your age is " + this.age);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            example anu = new example("Anurag",12);
            anu.getexample();

            example anu1 = new example(anu);
            anu1.getexample1();
            Console.ReadLine();
        }
    }
}
