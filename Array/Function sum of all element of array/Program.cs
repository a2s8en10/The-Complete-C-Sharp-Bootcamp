using System;

namespace Function_sum_of_all_element_of_array
{
    class Func
    {
        public
            int[] num1 = new int[5] { 2, 5, 3, 8, 4 };
        int sum = 0;

        public void Add()
        {
            foreach (int i in num1)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Func func = new Func();
            func.Add();
            Console.WriteLine();
        }
    }
}
