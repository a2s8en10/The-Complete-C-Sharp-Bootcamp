using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fname = new string[6];

            fname[0] = " Atishay";
            fname[1] = " Aryan";
            fname[2] = " Anurag";
            fname[3] = " Pranshu";
            fname[4] = " Pranay";
            fname[5] = " piyush";

            Console.WriteLine("input array...");
            Console.WriteLine("");
            Console.WriteLine(fname[0]);
            Console.WriteLine(fname[1]);
            Console.WriteLine(fname[2]);
            Console.WriteLine(fname[3]);
            Console.WriteLine(fname[4]);
            Console.WriteLine(fname[5]);

            Console.WriteLine("");
            Console.WriteLine("Revers data... ");

            Array.Reverse(fname);
            Console.WriteLine("");

            Console.WriteLine(fname[0]);
            Console.WriteLine(fname[1]);
            Console.WriteLine(fname[2]);
            Console.WriteLine(fname[3]);
            Console.WriteLine(fname[4]);
            Console.WriteLine(fname[5]);

            Console.ReadLine();
        }
    }
}
