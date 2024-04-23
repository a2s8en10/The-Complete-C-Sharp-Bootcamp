using System;
using System.Buffers;
using System.Collections.Generic;

namespace LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                name = "Anurag",
                id = 1,
                age = 20
            };
            Employee emp2 = new Employee()
            {
                name = "pride",
                id = 2,
                age = 21
            };
            Employee emp3 = new Employee()
            {
                name = "Relax",
                id = 3,
                age = 22
            };


            List<Employee> myemployee = new List<Employee>();
            myemployee.Add(emp1);
            myemployee.Add(emp2);
            myemployee.Add(emp3);

            foreach (Employee emp in myemployee)
            {
                Console.WriteLine("name : {0}  id : {1}  age : {2}",emp.name,emp.id,emp.age);
            }

            List<char> mychar = new List<char>();
            mychar.Add('A');
            mychar.Add('B');
            mychar.Add('C');
            mychar.Add('D');

            List<string> mystring = new List<string>();
            mystring.Add("Anurag");
            mystring.Add("Relax");
            mystring.Add("Pride");
            mystring.Add("Sahu");

            List<int> mynumbers = new List<int>();
            mynumbers.Add(11);
            mynumbers.Add(22);
            mynumbers.Add(33);
            mynumbers.Add(44);
          
            Console.ReadLine();
        }
    }
}
