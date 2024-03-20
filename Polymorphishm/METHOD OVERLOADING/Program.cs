using System;

namespace METHOD_OVERLOADING
{
    internal class Program
    {
        public void add ()
        {
            int a = 12;
            int b = 13;
            int c = a+b;
            Console.WriteLine(c);
        }
        public void add(int a,int b)
        {
           int c = a+b;
            Console.WriteLine(c);
        }
        public void add(string a,string b)
        {
            string c = a + " " +b;
            Console.WriteLine(c);
        }
        public void add(float a, float b)
        {
           float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.add();
            p1.add(2,3);
            p1.add("anurag","sahu");
            p1.add(12.2f, 123.4f);


           Console.ReadLine();
        }
    }
}
