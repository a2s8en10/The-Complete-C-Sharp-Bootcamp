using System;

namespace ABSTRACT_CLASS_AND_ABSTRACT_METHOD
{
    abstract class person
    {
        public string fname;
        public string lname;
        public int age;

        // use the properties
        public int Myage 
        {
            set
            {
                this.age = value;
            }
            get
            {
                return age;
            }
        }
        public abstract void showdetail();
    }
    class student : person
    {
        public int Rollno;
        public int fees;
        public override void showdetail()
        {
            string name = this.fname + " " +this.lname;
            Console.WriteLine("Name is : {0}",name);
            Console.WriteLine("Age is : {0}",this.age);
            Console.WriteLine("Roll Number is : {0}",this.Rollno);
            Console.WriteLine("Fees is : {0}",this.fees);
        }
    }
    class teacher : person
    {
        public int salary;
        public string department;
        public override void showdetail()
        {
            string name = this.fname + " " + this.lname;
            Console.WriteLine("Name is : {0}", name);
            Console.WriteLine("Age is : {0}", this.age);
            Console.WriteLine("Salary is : {0}", this.salary);
            Console.WriteLine("Department is : {0}", this.department);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student anu = new student();
            anu.fname = "Anurag";
            anu.lname = "sahu";
            anu.age = 20;
            anu.fees = 34304;
            anu.Rollno = 32;
            anu.showdetail();

            Console.WriteLine("-----------------------------");

            teacher obj = new teacher();
            obj.salary = 234324;
            obj.department = "cs department";
            obj.fname = "Relax";
            obj.lname = "Pride";
            obj.age = 34;
            obj.showdetail();
            Console.ReadLine();
        }
    }
}
