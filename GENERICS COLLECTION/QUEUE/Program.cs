using System;
using System.Collections;

namespace QUEUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myqueue = new Queue();
            myqueue.Enqueue("Anurag");
            myqueue.Enqueue(1234546789);
            myqueue.Enqueue(324.53);
            myqueue.Enqueue(true);
            myqueue.Enqueue('A');
            myqueue.Enqueue("sahu");

            foreach (var item in myqueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------Remove the top value");
            myqueue.Dequeue();
            foreach (var item in myqueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------check the queue value hai ya nahi");
            Console.WriteLine(myqueue.Contains("Anurag"));

            Console.WriteLine("----------check top value");
            Console.WriteLine(myqueue.Peek());

            Console.WriteLine("----------count the queue");
            Console.WriteLine(myqueue.Count);

            Console.WriteLine("----------clear the all value");
            myqueue.Clear();
            foreach (object item in myqueue)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
