using System;

namespace Array_student_mark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] student = new int[5];
            student[0] = 34;
            student[1] = 56;
            student[2] = 78;
            student[3] = 65;
            student[4] = 87;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Marks of student : "+student[i]);
            }
            Console.ReadLine();
        }
    }
}
