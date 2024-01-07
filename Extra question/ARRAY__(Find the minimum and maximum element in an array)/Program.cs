using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY___Find_the_minimum_and_maximum_element_in_an_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the number of array ? ");
            //int i = int.Parse(Console.ReadLine ());

            //-------Other Ways to Create an Array------

            //  1.  int[] num = { 24, 12, 54, 67, 47 };

            //  2.  int[] num = new int[5];

            //num[0] = 24;
            //num[1] = 12;
            //num[2] = 54;
            //num[3] = 67;
            //num[4] = 47;

            //  3.  int[] num = new int [] { 1, 2, 3, 4, 5};

            int[] num = new int[5];

            num[0] = 24;
            num[1] = 12;
            num[2] = 54;
            num[3] = 67;
            num[4] = 47;

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            Console.WriteLine(num[3]);
            Console.WriteLine(num[4]);

            //     FIND THE MAXIMUM ELEMENT 

            Console.WriteLine(" "); 
            Console.Write("MAXIMUM NUMBER OF ELEMENT : ");
            Console.Write(num.Max());


            //     FIND THE MINIMUM ELEMENT 

            Console.WriteLine(" ");
            Console.Write("MINIMUM NUMBER OF ELEMENT : ");
            Console.Write(num.Min());

            //     FIND THE SUM ELEMENT 

            Console.WriteLine(" ");
            Console.Write("SUM NUMBER OF ELEMENT : ");
            Console.Write(num.Sum());

            Console.ReadLine();
        }
    }
}
