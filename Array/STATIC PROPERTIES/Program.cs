using System;

namespace STATIC_PROPERTIES
{
    class student
    {
        private static string name;
        private static string id;

        public static string _name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Its not null and empty");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student._name = null;
            Console.WriteLine(student._name);
            Console.ReadLine();
        }
    }
}
