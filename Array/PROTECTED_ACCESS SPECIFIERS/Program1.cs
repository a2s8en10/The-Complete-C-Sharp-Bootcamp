﻿using System;

namespace PROTECTED_ACCESS_SPECIFIERS
{
    public class class1
    {
        protected void show1()
        {
            Console.WriteLine("protected");
        }
        public void show2()
        {
            class1 c1 = new class1();
            c1.show1();
        }
    }
    internal class Program1 : class1
    {
        static void Main(string[] args)
        {
            class1 c2 = new class1();
            c2.show2 ();

            Program1 p1 = new Program1 ();
            p1.show1();

            Console.ReadLine();
        }
    }
}
