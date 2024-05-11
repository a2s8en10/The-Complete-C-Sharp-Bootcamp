using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTENSION_METHODS
{
    internal class Textextension
    {
        static void Main()   // main method are static is important
        {
            Program p = new Program();
            p.func1();
            p.func2();
            p.func3(23);

            Console.ReadLine();
        }
    }
}
