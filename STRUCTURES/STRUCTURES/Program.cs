using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCTURES
{
    struct Program
    {
        public void func()
        {
            Console.WriteLine("function call first's.....");
        }
        static void Main(string[] args)
        {
            //Program p = new Program(); // structure and class object create
            //or 
            Program p; // without constructor structure object create
            p.func();
            Console.ReadLine();
        }
    }
}
