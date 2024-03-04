using System;

namespace Value_type_and_Reference_type
{

    //struct Employee 
    //{
    //    public int salary;
    //    public int age;
    //}
    class Employee
    {
        public int salary;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.salary = 1000;
            e.age = 23;

            Employee e1 = e;
            Employee e2 = e1;

            e.age = 20;

            Console.WriteLine(e.age);
            Console.WriteLine(e1.age);
            Console.WriteLine(e2.age);

            Console.ReadLine();
        }
    }
}
