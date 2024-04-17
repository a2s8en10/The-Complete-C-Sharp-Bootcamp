using System;

namespace EXPLICIT_IMPLEMENTATION_OF_INTERFACE
{
    interface a1
    {
        void show();
    }
    interface a2
    {
        void show();
    }
    class Myinterface :  a1,a2 
        {
        public void show()
        {
            Console.WriteLine("this is the interface of A1 !!");
        }

        //void a1.show()
        //{
        //    Console.WriteLine("this is the interface of A1 !!");
        //}

        void a2.show()
        {
            Console.WriteLine("this is the interface of A2 !!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            a1 obj1 = new Myinterface();
            obj1.show();

            a2 obj2 = new Myinterface();
            obj2.show();
            //Myinterface obj = new Myinterface();
            //obj.show();
            //((a2)obj).show();

            //Myinterface obj = new Myinterface();
            //((a1)obj).show();
            //((a2)obj).show();
            Console.ReadLine();
        }
    }
}
