using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVIDE_BY_ZERO_EXCEPTION
{
    internal class Class1
    {
        public int a;
        public int b;
        public void division(int a, int b)
        {
            this.a = a;
            this.b = b;
            try
            {
                int c = a / b;
                Console.WriteLine("Division is : {0}", c);
            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("you cannot divide a number is zero...");
                Console.WriteLine(Ex.Message);
            }
        }
    }
}