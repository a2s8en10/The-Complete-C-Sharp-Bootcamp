using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_MEMBER
{
    class person
    {
        public static string personname;
        public static int personid;
        public static int personage;
        public static int personhomenumber;

        static person()
        {
            personname = "Anaurag Sahu";
            personid = 24;
            personage = 20;
            personhomenumber = 127;

            Console.WriteLine("Person is call...");
        }
        
        public static void personalinfoget()
        {
            Console.WriteLine("Your name is : {0}",personname);
            Console.WriteLine("Your I'D is : {0}",personid);
            Console.WriteLine("Your Age is : {0}", personage);
            Console.WriteLine("Your Home number is : {0}",personhomenumber);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person.personalinfoget();
            Console.ReadLine();
        }
    }
}
