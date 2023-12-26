using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = " Nnurag ";
            //char chr = 'N'; 
            //Console.Write("{0} {1}",str,chr);

            string a = " \\name\\age\\pappu";

            string b = "\'school'\'class'\'student'\'";

            string c = "\n one \n two \n three \n our \n five ";

            String d = "\tcoole\tfan\tlcd\tmobile\tele\tvision ";

            string e = @" \\mere dil ne chun laiya ne tere dil diyan raaha \\ ";



            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);


            Console.ReadLine();
        }
    }
}
