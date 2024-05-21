using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_And_Await
{
    internal class Program
    {
        public static async void task1()
        {
            await Task.Run(() => 
            {
                Console.WriteLine("task 1 starting....");
                Thread.Sleep(5000);
                Console.WriteLine("task 1 complete");
                Console.WriteLine();
            });
          
        }
        public static async void task2()
        {
            await Task.Run(() => 
            {
                Console.WriteLine("task 2 starting....");
                Thread.Sleep(3000);
                Console.WriteLine("task 2 complete");
                Console.WriteLine();
            });

        }
        public static async void task3()
        {
            await Task.Run(() =>
            { 
                Console.WriteLine("task 3 starting....");
                Thread.Sleep(1000);
                Console.WriteLine("task 3 complete");
                Console.WriteLine();
            });
        }
        public static async void task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 4 starting....");
                Thread.Sleep(4000);
                Console.WriteLine("task 4 complete");
                Console.WriteLine();
            });
           
        }
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            Console.ReadLine();
        }
    }
}
