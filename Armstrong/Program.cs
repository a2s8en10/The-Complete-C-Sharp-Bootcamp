using System;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number are check Armstrong : ");
            int a = int.Parse(Console.ReadLine());
            int mainA = a;
            int i, k, j, sum = 0;
            for (i = 1; i <= 3; i++)
            {
                k = a % 10;
                j = a / 10;
                a = j;
               // Sigle value of (a) Print 
               // Console.WriteLine(k);

                sum = k * k * k + sum;
               // Console.WriteLine(sum);

                //if (a == sum)
                //{
                //    Console.WriteLine("This number are Armstrong.",sum);
                //}
                
            }
           // Console.WriteLine("This number are not Armstrong.");
           // check the sum 
           // Console.WriteLine(sum);

            if (sum == mainA)
            {
                Console.WriteLine("This number are Armstrong.",sum);
            }
            else
            {
                Console.WriteLine("This number are not Armstrong.",sum);
            }

            Console.ReadLine();
        }
    }
}
