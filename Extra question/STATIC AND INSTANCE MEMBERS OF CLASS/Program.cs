using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_AND_INSTANCE_MEMBERS_OF_CLASS
{
    internal class Program
    {
        class student    // INSTANCE member is the only create the object ( non-static) 
        {
           public string fname;
           public string lname;
           public int stander;
           public int id;
           public int age;
           public static string schoolname = "takshshila";   // static member is not create a object and not change a value and fix value
           public static int fees = 18500;
          
            public void fullname ()   // fullname
            {
                string name = this.fname + " " + this.lname;
                Console.WriteLine("Your name is : {0}",name);
            }
            public static int feesincrement(int fees)   // fees 
            {
                return fees / 10 - 50;
            }

        }
        static void Main(string[] args)
        {
            student anurag = new student();
            anurag.fname = "Anurag";
            anurag.lname = "Sahu";
            anurag.stander = 12;
            anurag.id = 24;
            anurag.age = 20;

            student pranshu = new student();
            pranshu.fname = "Pranshu";
            pranshu.lname = "Patel";
            pranshu.stander = 12;
            pranshu.id = 36;
            pranshu.age = 21;

            anurag.fullname ();
            Console.WriteLine("Your class is : {0}th",anurag.stander);
            Console.WriteLine("Your I'D is : {0}",anurag.id);
            Console.WriteLine("Your Age is : {0}",anurag.age);
            Console.WriteLine("My school name is : {0}",student.schoolname);
            Console.WriteLine("Your school fees is : {0}", student.fees);
            Console.WriteLine("Youe fees increment for next year : {0}",student.feesincrement(19500));

            Console.WriteLine("------------------------");
           
            pranshu.fullname();
            Console.WriteLine("Your class is : {0}th", pranshu.stander);
            Console.WriteLine("Your I'D is : {0}", pranshu.id);
            Console.WriteLine("Your Age is : {0}", pranshu.age);
            Console.WriteLine("My school name is : {0}", student.schoolname);
            Console.WriteLine("Your school fees is : {0}", student.fees);
            Console.WriteLine("Youe fees increment for next year : {0}", student.feesincrement(15500));
            Console.ReadLine();
        }
    }
}
