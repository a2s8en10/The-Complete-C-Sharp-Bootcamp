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
                age = 18
            };
            Employee emp3 = new Employee()
            {
                name = "Relax",
                id = 3,
                age = 42
            };


            List<Employee> myemployee = new List<Employee>();
            myemployee.Add(emp1);
            myemployee.Add(emp2);
            myemployee.Add(emp3);

            foreach (Employee emp in myemployee)
            {
                Console.WriteLine("name : {0}  id : {1}  age : {2}", emp.name, emp.id, emp.age);
            }

            //List<char> mychar = new List<char>();
            //mychar.Add('A');
            //mychar.Add('B');
            //mychar.Add('C');
            //mychar.Add('D');

            //List<string> mystring = new List<string>();
            //mystring.Add("Anurag");
            //mystring.Add("Relax");
            //mystring.Add("Sahu");
            //mystring.Add("Pride");
            //mystring.Add("Sahu");

            //foreach (string item in mystring)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("--------------------------");
           //Employee emp = myemployee.Find(myemployee => myemployee.age > 20);
           // foreach (Employee e in myemployee)
           // {
           //     Console.WriteLine("name : {0}  id : {1}  age : {2}", e.name, e.id, e.age);
           // }
            //mystring.Clear();

            //Console.WriteLine(mystring.LastIndexOf("Sahu")); //show the index number last value
            //Console.WriteLine(mystring.IndexOf("Sahu"));  // show the index number first value

            //mystring.Reverse();

            //Console.WriteLine(mystring.Exists(mystring => mystring.StartsWith("A")));  // return the boolean value
            //Console.WriteLine(mystring.Exists(mystring => mystring.EndsWith("u")));  // return the boolean value

            //Console.WriteLine(mystring.Contains("Anurag"));  // return boolean value
            //foreach (string item in mystring)
            //{
            //    Console.WriteLine(item);
            //}
            //List<int> mynumbers = new List<int>();
            //mynumbers.Add(33);
            //mynumbers.Add(11);
            //mynumbers.Add(44);
            //mynumbers.Add(22);

            // ---------------  PROPERTIES  --------------

            //mynumbers.Sort();
            //mynumbers.InsertRange(2, mynumbers); // insert index (index,object name)
            //mynumbers.Insert(2,66);  // value insert (index,value)
            //mynumbers.RemoveAll(mynumbers => mynumbers > 22); // lamda expresion use the predicate
            //mynumbers.RemoveRange(1,2);
            //mynumbers.RemoveAt(2);
            //mynumbers.Remove(11);
            //foreach (int i in mynumbers)
            //{
            //    Console.WriteLine(i);
            //}
            // mynumbers.AddRange(mynumbers);
            // Console.WriteLine(mynumbers.Count);
            // Console.WriteLine(mynumbers.Capacity);
            Console.ReadLine();
        }
    }
}
