using System;

namespace MULTIPLE_DELEGATES
{
    // this is use multiple delegates

    public delegate void claculation(int a, int b);
    public delegate void show();
    public delegate void power(int num);
    internal class Program
    {
        public static void square(int a)
        {
            int c = a * a;
            Console.WriteLine("square {0} is {1}",a,c);
        }
        public static void cube(int a)
        {
            int c = a * a * a;
            Console.WriteLine("Cube {0} is {1}",a,c);
        } 
        public static void show()
        {
            Console.WriteLine("This is show method...");
        }
        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is : {0}", c);
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

            claculation obj1 = new claculation(Program.Add);
            obj1.Invoke(10, 20);

            claculation obj2 = new claculation(Program.Subtract);
            obj2.Invoke(30, 20);

            claculation obj3 = new claculation(Program.Multi);
            obj3.Invoke(10, 2);

            claculation obj4 = new claculation(Program.Divide);
            obj4.Invoke(10, 5);

            show obj5 = new show(show);
            obj5.Invoke();

            power squ = new power(square);
            squ.Invoke(5);

            power cb = new power(cube);
            cb.Invoke(5);

            Console.ReadLine();
        }
    }

}
