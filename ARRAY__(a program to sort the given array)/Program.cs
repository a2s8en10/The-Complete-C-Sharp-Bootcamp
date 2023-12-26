using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY___a_program_to_sort_the_given_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[8];

            numbers[0] = 45;
            numbers[1] = 88;
            numbers[2] = 53;
            numbers[3] = 94;
            numbers[4] = 35;
            numbers[5] = 69;
            numbers[6] = 17;
            numbers[7] = 28;

            // sort is accending order  

            Array.Sort(numbers);

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]);
            //Console.WriteLine(numbers[6]);
            //Console.WriteLine(numbers[7]);

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();  // genrate a new line   



            // ---------ARRAY AND ARRAY DATA DEFINE BY USER ---------



            Console.WriteLine("How many number of element you want to store in array ?? ");
            int num = int .Parse(Console.ReadLine());

            int [] numbers1 = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the Array value " + i );
                int value = int.Parse(Console.ReadLine());
                numbers1[i] = value;
            }

            Console.WriteLine(); // new line 

            Console.WriteLine(" input data.... ");
            foreach (int item in numbers1) 
            {
                Console.WriteLine(item);
            }

            // sort data for accending order
            Console.WriteLine();


            ,ō
            Array.Sort(numbers1);
            Console.WriteLine(" accending order : ");

            foreach (int item in numbers1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
