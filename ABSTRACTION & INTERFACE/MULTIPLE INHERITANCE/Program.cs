using System;

namespace MULTIPLE_INHERITANCE
{
    class person
    {
        public void show()
        {
            Console.WriteLine("this is the method of person class !");
        }
    }
    interface student
    {
        void show();
    }
    interface teacher
    {
        void show();
    }

    internal class Program : person , student , teacher
    {
        void student.show()
        {
            Console.WriteLine("this is themethod of student interface !");
        }
        void teacher.show()
        {
            Console.WriteLine("this is themethod of teacher interface !");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show();
            //((student)obj).show();
            //((teacher)obj).show();
            
            student st = new Program();
            st.show();
            
            teacher te = new Program();
            te.show();

            Console.ReadLine();
        }
    }
}
