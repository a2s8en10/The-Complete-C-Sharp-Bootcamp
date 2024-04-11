using System;

namespace DELEGATES
{
    public delegate void claculation(int a, int b);
    internal class Program
    {
        public static void Add (int a ,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is : {0}",c);
        }
        public static void Subtract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Subtract is : {0}", c);
        }
        public static void Multi(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication is : {0}", c);
        }
        public static void Divide(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Divide is : {0}", c);
        }
        static void Main(string[] args)
        {
            // -------------input the value diffrent way ---------

            //claculation obj1 = new claculation(Program.Add);
            //obj1.Invoke(10,20);

            //claculation obj2 = new claculation(Program.Subtract);
            //obj2.Invoke(30,20);

            //claculation obj3 = new claculation(Program.Multi);
            //obj3.Invoke(10,2);

            //claculation obj4 = new claculation(Program.Divide);
            //obj4.Invoke(10,5);

            // -------------input the value diffrent way ---------

            //claculation obj = new claculation(Program.Add);
            //obj.Invoke(10,20);

            //obj = Subtract;
            //obj(30,20);

            //obj = Divide;
            //obj(10, 5);

            //obj = Multi;
            //obj(10, 2);

            Console.ReadLine();
        }
    }
}
