using System;

namespace Find_he_length_of_Array
{
    class Func
    {
        public
            int[] num = new int[] { 1, 23, 4, 8, 3, 35, 2, 5, 2, 54 };

        int count;
        public void length()
        {
            foreach (int i in num)
            {
                count++;
            }

            Console.WriteLine("The Length of Array : " + count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Func Array = new Func();
            Array.length();
            Console.WriteLine();
        }
    }
}
