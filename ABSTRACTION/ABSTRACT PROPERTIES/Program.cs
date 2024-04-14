using System;
using System.Runtime.CompilerServices;

namespace ABSTRACT_PROPERTIES
{
    abstract class person
    {
        public abstract uint id { get; set; }
        public abstract string name { get; set; }
    }
    class student : person
    {
        uint stdID;
        string stdName;

        public override uint id
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("ID is not zero and negetive !");
                }
                else
                {
                    this.stdID = value;
                }
            }
            get 
            {
                return this.stdID;
            } 
        }
        public override string name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name is not Null and Empty !");
                }
                else 
                { 
                    this.stdName = value; 
                }
            }

            get
            {
                return this.stdName;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student anu = new student();
            anu.id = 0;
            anu.name = "Anurag";

            Console.WriteLine(anu.name);
            Console.WriteLine(anu.id);

            Console.ReadLine();

        }
    }
}
