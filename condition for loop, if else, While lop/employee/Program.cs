using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee.Models;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name="jay patel" , Designation = "hello" ,Age = 23 },
                new Employee() { Id = 2, Name="Ashish sahu" , Designation = "hello byy" ,Age = 24 },
                new Employee() { Id = 3, Name="Anurag sahu" , Designation = "hello hii" ,Age = 25 },
            };
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.Name +" " + employee.Description + " " + employee.Age);
            //}

            Console.WriteLine("Press 1 to Get All Employee Details");
            Console.WriteLine("Press 2 to Get Employee Details By ID");
            Console.WriteLine("Press 3 to Add Employee ");
            Console.WriteLine("Press 4 to Update Employee ");
            Console.WriteLine("Press 5 to Delete Employee ");

            Console.WriteLine();

            Console.Write("Enter the  number : ");
            int press = int.Parse(Console.ReadLine());

            switch (press)
            {
                case 1:
                    Console.WriteLine("All employee details...");
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Designation + " " + employee.Age);
                    }
                    break;

                case 2:
                    Console.Write("Enter the ID :");
                    int num = int.Parse(Console.ReadLine());


                    foreach (Employee employee in employees)
                    {
                        if (employee.Id == num) { Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Designation + " " + employee.Age); }

                    }

                    break;

                case 3:
                    Console.WriteLine("Enter the number of Add employee :");
                    int add = int.Parse(Console.ReadLine());

                    break;

                case 4:
                    //foreach (Employee employee in employees)
                    //{
                    //    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Designation + " " + employee.Age);
                    //}
                    Console.Write("Enter the Employee ID updated :");
                    int num1 = int.Parse(Console.ReadLine());
                    string des = Console.ReadLine();

                    foreach (Employee employee in employees)
                    {
                        if (employee.Id == num1) 
                        {
                            employee.Designation = "manager";
                            Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Designation + " " + employee.Age); 
                        }
                      
                    }








                    Console.WriteLine();
                    //Console.WriteLine("Before employee updated..");
                    //foreach (var employee in emp1)
                    //{
                    //    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Designation + " " + employee.Age);
                    //}
                    //Console.WriteLine();

                    Console.Write("What to update :");



                    Console.WriteLine("Update the {0}");
                    break;

                case 5:
                    Console.WriteLine("Press 5 to Delete Employee ");
                    break;

                default:
                    Console.WriteLine(" default case... ");
                    break;


            }
            Console.ReadLine();
        }
    }
}
