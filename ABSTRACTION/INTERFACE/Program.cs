using System;

namespace INTERFACE
{
    interface person // define only properties , method , and events which is the member of the interface
                     // interface contain only the declaration of the member.
    {
        void show ();
    }
    class student : person // it is the responsibility of the deriving class to define the member
    {
        public void show()
        {
            Console.WriteLine("This is called interface ! ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student anu = new student();
            anu.show();
            Console.ReadLine();
        }
    }
}
