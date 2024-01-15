using System;

namespace descending_order_in_Array
{
    class Func
    {
        public
            int[] num = new int[5] { 2, 3, 7, 9, 1 };

        public void asc()
        {
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        a = num[j + 1];

                        num[j + 1] = num[j];

                        num[j] = a;
                    }
                }

            }

            Console.WriteLine("descending is ");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Func func = new Func();
            func.asc();
            Console.WriteLine();

        }
    }
}
