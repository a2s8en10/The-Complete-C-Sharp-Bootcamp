using System;

namespace ACCESS_SPECIFIERS_1
{
    public class info
    {
        public void show1()
        {
            Console.WriteLine("Anurag");
        }
        //public void show2()
        //{
        //    info x = new info();
        //    x.show1();
        //}
    }
    internal class Program1 //: info
    {
        static void Main(string[] args)
        {
            //info anu = new info();
            //anu.show2();

            //Program1 anu = new Program1 ();
            //anu.show1();




            Console.ReadLine();
        }
    }
}
