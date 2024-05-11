using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTENSION_METHODS
{
    internal class Program
    {
        public void func1()
        {
            Console.WriteLine("Anurag sahu");
        }
        public void func2()
        {
            Console.WriteLine("Pride");
        }
        static void Main(string[] args)
        {
            Program p = new Program();  // this class are not run because extension class are run 
            p.func1();
            p.func2();
            Console.ReadLine();
        }
    }
}
