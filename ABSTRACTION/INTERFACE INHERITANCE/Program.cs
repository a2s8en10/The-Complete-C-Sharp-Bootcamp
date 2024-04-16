using System;

namespace INTERFACE_INHERITANCE
{
    interface a1
    {
        void show1();
    }
    interface a2
    {
        void show2();
    }
    interface a3 : a1,a2
    {
        void show3();
    }
    internal class Program : a3
    {

        public void show1()
        {
            Console.WriteLine("the interface of A1");
        }

        public void show2()
        {
            Console.WriteLine("the interface of A2");
        }

        public void show3()
        {
            Console.WriteLine("the interface of A3");
        }
        static void Main(string[] args)
        {
           
        }
    }
}
