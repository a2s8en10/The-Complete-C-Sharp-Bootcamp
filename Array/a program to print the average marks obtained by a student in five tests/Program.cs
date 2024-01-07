using System;

namespace a_program_to_print_the_average_marks_obtained_by_a_student_in_five_tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of subject : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] average = new int[num];

            Console.WriteLine("Enter the marks : ");
            for (int i = 0; i < num; i++)
            {
                int a = int.Parse(Console.ReadLine());
                average[i] = a;
            }

            for (int i = 0; i < average.Length; i++)
            {
                sum = sum + average[i];
            }

            Console.WriteLine("total number : " + sum);
            sum = sum / num;
            Console.WriteLine("the_average_marks_obtained_by_a_student : " + sum);
            Console.ReadLine();
        }
    }
}
