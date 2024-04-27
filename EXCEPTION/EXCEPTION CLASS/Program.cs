using System;

namespace EXCEPTION_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);

                //int[] a = new int[3];
                //a[0] = 1;
                //a[1] = 2;
                //a[2] = 3;
                //a[3] = 4;
                //foreach (int i in a)
                //{
                //    Console.WriteLine(i);
                //}

                //string a = null;
                //Console.WriteLine(a.Length);

                //string a = "fhd";
                //int num = int.Parse(a);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
