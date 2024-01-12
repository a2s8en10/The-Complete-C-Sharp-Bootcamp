using System;

namespace the_smallest_element_in_the_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            num[0] = 3;
            num[1] = 7;
            num[2] = 1;
            num[3] = 9;
            num[4] = 4;

            int a = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length - 1; j++)
                {
                    if (num[i] > num[j])
                    {
                        a = num[j];

                        num[j] = num[i];

                        num[i] = a;
                    }
                }
               
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
