using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOXING___UNBOXING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing 
            int a = 7;
            object obj1 = a;  // value to typecasting(convert) reference type its a boxing
            Console.WriteLine(obj1);

            // unboxing
            int b = 7;  // int is value type
            object obj2 = b; // Reference convert to value type its a unboxing , object is reference 
            int c = (int)obj2;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
