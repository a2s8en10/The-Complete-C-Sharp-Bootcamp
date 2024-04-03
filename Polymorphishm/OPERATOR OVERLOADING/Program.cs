using System;

namespace OPERATOR_OVERLOADING
{
    internal class Program
    {
        class Newclass
        {
            public string name;
            public int num;

            public static Newclass operator +(Newclass obj1, Newclass obj2)
            {
                Newclass obj3 = new Newclass();
                obj3.name = obj1.name + " " + obj2.name;
                obj3.num = obj2.num + obj2.num;

                return obj3;
            }


        }
        static void Main(string[] args)
        {
            Newclass obj1 = new Newclass();
            obj1.name = "Anurag";
            obj1.num = 10;

            Newclass obj2 = new Newclass();
            obj2.name = "Sahu";
            obj2.num = 20;

            Newclass obj3 = new Newclass();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.num);
            Console.ReadLine();
        }
    }
}
