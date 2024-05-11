using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globally_Unique_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid a = new Guid();
            //Console.WriteLine(a.ToString().Replace("-",string.Empty)); // remove (-) 
            //Console.WriteLine(a.ToString("N")); // remove (-)
            Console.WriteLine(a.ToString().Substring(0,15)); // Identifier digit 

            Console.ReadLine();
        }
    }
}
