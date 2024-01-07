using System;

namespace a_program_to_input_a_string_through_the_keyboard_and_print_the_same
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name :");
            string str = Console.ReadLine();

            string[] name = new string[5];
            for (int i = 0; i < 5; i++)
            {
                string a = Console.ReadLine();
                name[i] = a;
            }
            Console.ReadLine();

        }
    }
}
