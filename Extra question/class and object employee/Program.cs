using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object_employee
{
    internal class Program
    {
        string emplname;
        int emplid;
        int emplage;
        string empldeparment;

        public void setemployee(string emplname,int emplid,int emplage,string empldepartment)
        {
            this.emplname = emplname;
            this.emplid = emplid;
            this.emplage = emplage;
            this.empldeparment = empldepartment;
        }

        public void getemployee()
        {
            Console.WriteLine("Enter the Name : " + emplname);
            Console.WriteLine("Enter the I'D : " + emplid);
            Console.WriteLine("Enter the Age : " + emplage);
            Console.WriteLine("Enter the Department : " + empldeparment);
        }

        static void Main(string[] args)
        {
            Program empl = new Program();

            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your I'D :");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Age :");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Department :");
            string Department = (Console.ReadLine());

            empl.setemployee(name,id,age,Department);
            empl.getemployee();

            Console.ReadLine();

        }
    }
}
