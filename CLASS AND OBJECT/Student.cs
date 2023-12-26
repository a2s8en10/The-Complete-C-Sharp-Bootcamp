using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_AND_OBJECT
{
    internal class Student
    {
        string name;
        int age;
        int stander;
        int rollno;

        public void setstudent(string name ,int age  ,int stander ,int rollno ) // set as a intput 
        {
            this.name = name;
            this.age = age;
            this.stander = stander;
            this.rollno = rollno;
        }
        public void getstudent() // get as a output
        {
            Console.WriteLine("Your name is {0}",this.name);
            Console.WriteLine("Your age is {0}", this.age);
            Console.WriteLine("Your stander is {0}", this.stander);
            Console.WriteLine("Your roll no. is {0}", this.rollno);
        }

        static void Main(string[] args) 
        {
            Student anu = new Student();

            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age :");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your stander :");
            int stander = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your rollno :");
            int rollno = int.Parse(Console.ReadLine());

            //anu.setstudent("anurag", 20, 12, 24);
            anu.setstudent(name,age,stander,rollno);
            anu.getstudent();

            Console.ReadLine();


        }
    }
}
