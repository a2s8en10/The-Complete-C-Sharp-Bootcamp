using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_OVERLOADING
{
    class student
    {
        // CONSTRUCTOR_OVERLOADING = CONSTRUCTOR_OVERLOADING is the same contructor name
        // but diffrent parameters are the CONSTRUCTOR_OVERLOADING
        public student() // no parameter 
        {
            Console.WriteLine("No parameter");
        }
        public student(int a) // 1 parameter 
        {
            Console.WriteLine("1 parameter");
        }
        public student(int a, int b)  // 2 parameter 
        {
            Console.WriteLine("2 parameter");
        }
        public student(string a) // 1 parameter with string 
        {
            Console.WriteLine("1 parameter with string");
        }
        public student(string a, string b) // 2 parameter with same data type 
        {
            Console.WriteLine("2 parameter with same data type ");
        }
        public student(int a, string b) // 2 parameter with diffrent data type 
        {
            Console.WriteLine("2 parameter with diffrent data type ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student(234);  // only parameter show 
            Console.ReadLine();
        }
    }
}
