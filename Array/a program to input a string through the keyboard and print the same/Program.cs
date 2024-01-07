using System;

namespace a_program_to_input_a_string_through_the_keyboard_and_print_the_same
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name :");
            //string str = Console.ReadLine();

            string[] name = new string[a];
            for (int i = 0; i < a; i++)
            {
                string b = Console.ReadLine();
                name[i] = b;
            }

            Console.WriteLine("output : ");
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
