using System;

namespace Class_and_Object
{
    internal class Employee
    {
        class employee
        {
            int id;
            string firstname;
            string lastname;
            int age;
            int salary;

            public void setemployee(int id, string firstname, string lastname, int age, int salary)
            {
                this.id = id;
                this.firstname = firstname;
                this.lastname = lastname;
                this.age = age;
                this.salary = salary;
            }

            public void getemployee()
            {
                Console.WriteLine("Id is : {0} ", this.id);
                Console.WriteLine("Firstname is : {0} ", this.firstname);
                Console.WriteLine("Lastname is : {0} ", this.lastname);
                Console.WriteLine("Age is : {0} ", this.age);
                Console.WriteLine("Salary is : {0} ", this.salary);
            }
        }

        static void Main(string[] args)
        {
            //employee E1 = new employee();
            //E1.setemployee(254,"Anurag","sahu",20,1200);
            //E1.getemployee();
            //Console.ReadLine();

            employee E2 = new employee();
            E2.setemployee(312,"ewf","few",23,2000);
            E2.getemployee();
            Console.ReadLine();
        }
    }
}
