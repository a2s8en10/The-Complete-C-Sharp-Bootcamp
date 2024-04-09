using System;

namespace INDEXERS
{
    class Employee
    {
        private int[] Age = new int[3];
        public int this[int index]
        {
            set 
            {
                if(index>=0 && index<Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("invailid value !");
                    }
                }
                else
                {
                    Console.WriteLine("invailid index ! (index range is {0})",Age.Length-1);
                }
            }
            get 
            {
                return Age[index]; 
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[2] = 4;

            Console.WriteLine(emp[2]);
            Console.ReadLine();
        }
    }
}
