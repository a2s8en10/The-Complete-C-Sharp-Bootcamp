using System;

namespace Largest_Value_in_Array
{
    class Func
    {
        public
            int[] num = new int[5] { 1, 2, 3, 34, 73 };

        public void num1()
        {
            // Array length 
            int count = 0;
            foreach (int i in num)
            {
                count++;
            }

            // sort Array
            int a = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        a = num[j + 1];

                        num[j + 1] = num[j];

                        num[j] = a;
                    }
                }

            }

            Console.Write("Largest value in Array : "+num[count - 1]);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Func func = new Func();
            func.num1();
            Console.ReadLine();
        }
    }
}
