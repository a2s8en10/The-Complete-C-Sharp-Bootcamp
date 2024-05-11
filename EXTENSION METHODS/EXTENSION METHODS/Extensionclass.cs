using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTENSION_METHODS
{
    static class Extensionclass   // only static class are extension class 
    {
        public static void func3(this Program p, int a)  // this keyword use the binding and p is variable name like this (string s)
        {
            Console.WriteLine("Realx.Anurag"+ a);
        }
    }
}
