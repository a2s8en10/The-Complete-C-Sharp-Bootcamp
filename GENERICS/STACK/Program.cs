using System;
using System.Collections;

namespace STACK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("Anurag");
            mystack.Push(1234567890);
            mystack.Push("0198CS221024");
            mystack.Push(20);
            mystack.Push("sahu");

            Console.WriteLine("Print all stack:-");
            foreach (object i in mystack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("check the input vailid and invailid:-");
            Console.WriteLine(mystack.Contains("Anurag"));

            Console.WriteLine("Remove the top value :-");
            mystack.Pop();
            foreach (object i in mystack)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
