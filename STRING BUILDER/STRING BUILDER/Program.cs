using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING_BUILDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Append = Write and appendLine = WriteLine (are same work)  
            StringBuilder sb = new StringBuilder("Anurag ");
            sb.AppendLine("sahu ");
            sb.Append("B tech");
            //Console.WriteLine(sb);

            // initial capacity of charater   { defalut charater 16 }
            StringBuilder sb1 = new StringBuilder("Anurag",50);
            StringBuilder sb2 = new StringBuilder(50);

            // AppendFormat N is number , C is currency , X is Hexadecimal 
            StringBuilder sb3 = new StringBuilder("your total ammount is : ");
            sb3.AppendFormat("{0:N}",25);
            //Console.WriteLine(sb3);

            // insert the string with index position 
            StringBuilder sb4 = new StringBuilder("Anurag sahu",20);
            sb4.Insert(0, "Mr.");
            //Console.WriteLine(sb4);

            // Remove string index no. and no. of digit
            StringBuilder sb5 = new StringBuilder("Anurag sahu", 20);
            sb5.Remove(7,4);
            //Console.WriteLine(sb5);

            // Replace string with (old string) and (new string)
            StringBuilder sb6 = new StringBuilder("Anurag sahu");
            sb6.Replace("Anurag","Realx");
            sb6.Replace("sahu", "Anurag");
            //Console.WriteLine(sb6);

            // convert the stringbuilder to string 
            StringBuilder sb7 = new StringBuilder("Anurag sahu");
            string s1 = sb7.ToString();
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
