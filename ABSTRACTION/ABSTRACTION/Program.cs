using System;

namespace ABSTRACTION
{
    class employee
    {
        public int id;
        public string name;
        public int age;
        public int salary;

        public employee(int id, int age ,int salary, string name)
        {
            this.id = id;
            this.age = age;
            this.salary = salary;
            this.name = name;
        }
        private void checkage(int age)
        {
            if (age <= 0)
            {
                Console.WriteLine("Age is not zero & negetive !");
            }
            else
            {
                Console.WriteLine("Age is {0}",age);
            }
        }
        public void employeedetaile()
        {
            Console.WriteLine("Name is : {0}",this.name);
            Console.WriteLine("Age is : {0}", this.age);
            Console.WriteLine("salary is : {0}", this.salary);
            Console.WriteLine("I`D is : {0}", this.id);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee (43,0,132098, "Anurag");
            obj.
            obj.employeedetaile();
            Console.ReadLine();
        }
    }
}
