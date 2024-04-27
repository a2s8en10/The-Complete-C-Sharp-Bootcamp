using System;

namespace INDEX_OUT_OF_RANGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            try
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;

                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException Ex)
            {
                Console.WriteLine("Array`s length is out of range...");
                Console.WriteLine(Ex.Message);
            }
            Console.ReadLine();
        }
    }
}
