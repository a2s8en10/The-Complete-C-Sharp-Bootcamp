using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MULTI_THREADING
{
    internal class Program
    {
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("function 1 {0}",i);
            }
        }
        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("function 2 {0}", i);
            }
        }
        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("function 3 {0}", i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            t1.Start();
            t2.Start();
            t3.Start();
          
            //Program.func1();
            //Program.func2();
            //Program.func3();

            Console.ReadLine();
        }
    }
}
