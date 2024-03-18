using System;
using System.Xml.Linq;

namespace ENCAPSULATION
{
    class person
    {
        private string name;
        private int age;

        public void setperson(string Name, int Age)
        {
            // name is null 
            if(string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name is required...");
            }
            else
            {
                this.name = Name;
            }
            // Age is not negetive and zero 
            if(Age > 0)
            {
                this.age = Age;
            }
            else
            {
                Console.WriteLine("Age is not zero and negetive...");
            }
        }
        public void getperson()
        {
            if (string.IsNullOrEmpty(name))
            {
                
            }
            else
            {
            Console.WriteLine("Name is :"+this.name);   
            }
            // Age is not negetive and zero 
            if (age > 0)
            {
                Console.WriteLine("Age is :" + this.age);
            }
            else
            {
               
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the Age: ");
            int age = int .Parse(Console.ReadLine());
          
            
            p1.setperson(name,age);
            p1.getperson();
            Console.ReadLine();
        }
    }
}
