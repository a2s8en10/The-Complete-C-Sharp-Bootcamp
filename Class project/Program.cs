using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_project
{
    internal class Program
    {
        string fname;
        string lname;
        int id;
        int age;
        string address;

        public void setinfo (string name, string lname, int id, int age, string address) // input value  
        {
            this.fname = name;
            this.lname = lname;
            this.id = id;
            this.age = age;
            this.address = address;
        }

        public void getinfo()
        {
            Console.WriteLine("Your frist name is : {0}",this.fname);
            Console.WriteLine("Your surname is : {0}", this.lname);
            Console.WriteLine("Your id is : {0}",this.id);
            Console.WriteLine("Your age is : {0}", this.age);
            Console.WriteLine("Your address is : {0}", this.address);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Frist name :");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter your Surname name :");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter your I'D :");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Age :");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Address :");
            string address = (Console.ReadLine());

            Console.WriteLine();
            Program anu = new Program();
            anu.setinfo(fname,lname,id,age,address);
            anu.getinfo();
            Console.ReadLine();
        }
    }
}
