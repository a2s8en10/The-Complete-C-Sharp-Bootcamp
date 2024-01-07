using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_CONSTRUCTOR__CREATE
{
    internal class employee
    {
        string name;
        int id;
        int age;
        string work;
        string address;

        public employee (string name,int id, int age, string work, string address)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.work = work;
            this.address = address;
        }
        // get statement 
        public string getname()
        {
            return this.name;
        }
        public int getId()
        {
            return this.id;
        }
        public int getage()
        {
            return this.age;
        }
        public string getwork()
        {
            return this.work; 
        }
        public string getaddress()
        {
            return this.address;
        }

        static void Main(string[] args)
        {
                Console.WriteLine("Enter your Name :");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your Work :");
                string work = Console.ReadLine();

                Console.WriteLine("Enter your Address :");
                string address = Console.ReadLine();

                Console.WriteLine("Enter your I'D :");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Age :");
                int age = int.Parse(Console.ReadLine());

            employee sahu = new employee(name,id,age,work,address);

            Console.WriteLine();

            Console.WriteLine(sahu.getname());
            Console.WriteLine(sahu.getId());
            Console.WriteLine(sahu.getage());
            Console.WriteLine(sahu.getwork());
            Console.WriteLine(sahu.getaddress());


            Console.ReadLine();
        }
    }
}
