using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_or_AS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            //bool b = a is int;
            //Console.WriteLine(b);

            if(a is int)
            {
                Console.WriteLine("A is int");
            }
            else
            {
                Console.WriteLine("A is another type");
            }



            Console.ReadLine();
        }
    }
}
