using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIVATE_CONSTRUCTOR
{

    class student
    {
        private student()
        {

        }

        public student()
        {
            Console.WriteLine("No parameter");
        }
        public student(int a)
        {
            Console.WriteLine("1 parameter");
        }
        public student(int a, int b)
        {
            Console.WriteLine("2 parameter");
        }
        public student(string a)
        {
            Console.WriteLine("1 parameter with string");
        }
        public student(string a, string b)
        {
            Console.WriteLine("2 parameter with same data type ");
        }
        public student(int a, string b)
        {
            Console.WriteLine("2 parameter with diffrent data type ");
        }
    }

        internal class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
