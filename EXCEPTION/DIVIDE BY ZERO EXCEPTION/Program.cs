using System;

namespace DIVIDE_BY_ZERO_EXCEPTION
{
    class calculator
    {
       public int a;
       public int b;

        public void add(int num1,int num2)
        {
            this.a = num1;
            this.b = num2;
            int c = num1 + num2;
            Console.WriteLine("Addition is : {0}",c);
        }
        public void subtract(int x, int y)
        {
            this.a = x;
            this.b = y;
            int c = x - y;
            Console.WriteLine("subtract is : {0}", c);
        }
        public void multi(int a, int b)
        {
            this.a = a;
            this.b = b;
            int c = a * b;
            Console.WriteLine("Multiplication is : {0}", c);
        }
        public void divide(int a, int b)
        {
            this.a = a;
            this.b = b;
            try
            {
                int c = a / b;
                Console.WriteLine("Division is : {0}", c);
            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("you cannot divide a number is zero...");
                Console.WriteLine(Ex.Message);
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            calculator obj = new calculator();
            Class1 c1 = new Class1();

            Console.Write("Enter the first number : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("----------- internal class ------------");

            obj.add(a,b);
            obj.divide(a,b);
            obj.multi(a,b);
            obj.subtract(a,b);

            Console.WriteLine("--------------- out side of class ----------------");

            c1.division(a,b);

            Console.WriteLine("------------- Main class ---------------");

            Console.Write("Enter the first number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("you cannot divide a number is zero...");
                Console.WriteLine(Ex.Message);
            }
            Console.ReadLine();

        }
    }
}
