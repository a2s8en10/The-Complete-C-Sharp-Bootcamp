using System;
using System.Threading.Tasks;

namespace LAMBDA_EXPRESSION
{
    public delegate void lambda(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            lambda obj1 = (b) => b++;
            obj1.Invoke(2);


            //lambda obj = (a) =>
            //{
            //    a += 10;
            //    Console.WriteLine(a);
            //};
            //// obj(20);
            //obj.Invoke(5);

            Console.ReadLine();
        }
    }
}
