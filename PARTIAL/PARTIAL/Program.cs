using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            obj.Firtstname = "Anurag";
            obj.Lastname = "sahu";
            Console.WriteLine("Your name is {0}",obj.fullname());
            Console.ReadLine();
        }
    }
}
