using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TYPE__CONVERSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 165;
            float b = a;

            float c = 12.34f;
            int d = (int)c;

            double e = 213.5469348712;
            float f = (float) e;

            string s = " 54";
            int i = int.Parse(s);


            string s2 = "21.34";
            float f2 =float.Parse(s2);

            string s3 = "c";
            char c3 = char.Parse(s3);

            string s4 = "533";
            int  z = Convert.ToInt32(s4);




            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(f2);
            Console.WriteLine(c3);
            Console.WriteLine(z);

            Console.ReadLine();
        }

    }
}
