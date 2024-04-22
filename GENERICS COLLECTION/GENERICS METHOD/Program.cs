using System;

namespace GENERICS_METHOD
{
    class generics
    {
        public static void show1<T>(T[] arr)  // T is the any type (any data type)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        public static bool show2<T>(T a , T b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("interger value...");
            int[] num = new int[2];
            num[0] = 1;
            num[1]= 2;
            generics.show1(num);

            Console.WriteLine("string value...");
            string[] arr = new string[2];
            arr[0] = "Anurag";
            arr[1] = "sahu";
            generics.show1(arr);

            Console.WriteLine("double data type value...");
            double[] num1 = new double[2];
            num1[0] = 3.32;
            num1[1] = 6.34448;
            generics.show1(num1);

            Console.WriteLine("boolean value..");
            Console.WriteLine(generics.show2(10,29));


            Console.ReadLine();
        }
    }
}
