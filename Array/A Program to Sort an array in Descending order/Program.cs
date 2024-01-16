using System;

namespace A_Program_to_Sort_an_array_in_Descending_order_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array :");
            int a = int.Parse(Console.ReadLine());

            int[] arr = new int[a];
            Console.WriteLine("Enter the Element :");

            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            // Find Array length 
            int count = 0;
            foreach (int item in arr)
            {
                count++;
            }

            // Find sort Array 
            int temp;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count- 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Descending order loop 
            Console.WriteLine("Sort an array in Descending order ");
            for (int i = count -1 ;i >=0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
