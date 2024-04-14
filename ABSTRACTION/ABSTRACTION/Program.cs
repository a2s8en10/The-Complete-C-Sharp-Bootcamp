using System;

namespace ABSTRACTION
{
    class employee
    {
        public int id;
        public string name;
        public int age;
        public int salary;
        

        public employee(int Id, int Age,int Salary, string Name)
        {
            this.id = Id;
            this.age = Age;
            this.name = Name;
            this.salary = Salary;
        }
        void checkage()
        {
            if (age <= 0)
            {
                Console.WriteLine("Age is not zero & negetive !");
            }
            else
            {
                Console.WriteLine("Age is : {0}",age);
            }
        }
        public void employeedetaile()
        {
            Console.WriteLine("Name is : {0}",this.name);
            Console.WriteLine("I`D is : {0}", this.id);
            Console.WriteLine("Salary is : {0}",this.salary);
            this.checkage();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee (43,20,23888,"Anurag");
            obj.employeedetaile();
            Console.ReadLine();
        }
    }
}
