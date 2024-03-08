using System;

namespace Constructor
{
    class user
    {
        public int id;
        public string name;
        public int age;
        public string email;
        //public user() // default constructor  
        //{
        //    Console.WriteLine("constructor are called");
        //}
        public user (int id,string name, int age , string email )
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            user con = new user();
            Console.ReadLine();
        }
    }
}
