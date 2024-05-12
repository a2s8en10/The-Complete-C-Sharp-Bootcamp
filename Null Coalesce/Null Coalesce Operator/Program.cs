using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Coalesce_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string result = name ?? "Enter the string..."; // it is null coalesh operator
            Console.WriteLine(result);

            string f1 = null;
            string f2 = null;
            string f3 = null;

            string result1 = f1 ?? f2 ?? f3 ?? "fruit name...";   // first is call f1 if f1 is null then f2 f2 is null then f3 
            Console.WriteLine(result1);

            //if (name != null)
            //{
            //    result = name;
            //}
            Console.ReadLine();

        }
    }
}
