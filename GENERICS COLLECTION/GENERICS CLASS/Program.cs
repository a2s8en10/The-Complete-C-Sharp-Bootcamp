using System;

namespace GENERICS_CLASS
{
    class generic<T>
    {
        private T num;

        //public T show 
        //{
        //    set
        //    {
        //        this.num = value;
        //    }
        //    get
        //    {
        //        return this.num;
        //    }

        //}
        public generic(T a) 
        {
            this.num = a;
        }
        public T get()
        {
            return this.num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            generic<int> g = new generic<int>(2);
            Console.WriteLine(g.get());

            generic<string> g1 = new generic<string>("Anurag sahu");
            Console.WriteLine(g1.get());

            generic<char> g2 = new generic<char>('R');
            Console.WriteLine(g2.get());

            Console.ReadLine();
        }
    }
}
