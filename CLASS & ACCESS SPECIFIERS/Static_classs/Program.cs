using System;

namespace Static_classs
{
    static class school
    {
        public static string name;
        public static int stander;
        public static int fees;

        static school ()
        {
            name = "Taksh Shila Academy";
            stander = 12;
            fees = 18000;
        }

        public static void getschooldetail ()
        {
            Console.WriteLine("School name is : {0}" ,name);
            Console.WriteLine("School in Class Room is : {0}", stander);
            Console.WriteLine("School Fees Amount is : {0}", fees);
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            school.getschooldetail();
            Console.ReadLine();
        }
    }
}
