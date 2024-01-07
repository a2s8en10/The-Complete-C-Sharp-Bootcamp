using System;

namespace a_program_to_print_a_string_using_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());


            int num = 5;
            string[] str = new string[num];
            str[0] = "Anurag";
            str[1] = "Pride";
            str[2] = "Anura sahu";
            str[3] = "Anu";
            str[4] = "sahu";

            Console.WriteLine("Enter the index number ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(str[i]);


            //Console.WriteLine("Enter the {0} name :", num);
            //for (int i = 0; i < num; i++)
            //{
            //    string s = Console.ReadLine();
            //    str[i] = s;
            //}

            //foreach (string name in str)
            //{
            //    Console.WriteLine(name);
            //}
            Console.ReadLine();

        }
    }
}
