using System;

namespace ANONYMOUS_FUNCTION___ANONYMOUS_METHOD
{
    public delegate void mydelegate(int a);
    internal class Program
    {
        public static void mymethod(mydelegate del, int num)
        {
            num += 10;
            del.Invoke(num);
        }

        //public static void add(int num)
        //{
        //    num += 10;
        //    Console.WriteLine(num);
        //}
        static void Main(string[] args)
        {
            //mydelegate del = new mydelegate(add);
            // del(12);

            // anonymous function

            mydelegate del = delegate (int num)
            {
                num += 10;
                Console.WriteLine(num);
            };
            //del(10);
            del.Invoke(10);

            // parameter anonymous method 

            Program.mymethod( delegate(int a) { a += 10; Console.WriteLine(a); }, 4);


            Console.ReadLine();
        }
    }
}
