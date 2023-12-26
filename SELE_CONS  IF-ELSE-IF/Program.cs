using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SELE_CONS__IF_ELSE_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Percentage : ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 75)
            {
                Console.Write(" Grade A : ");
            }

            else if (a >= 60)
            {
                Console.WriteLine(" Grade B : ");
            }

            else if (a >= 54)
            {
                Console.WriteLine(" Grade C : ");
            }

            else if (a >= 45)
            {
                Console.WriteLine(" Grade D : ");
            }

            else if (a >= 33)
            {
                Console.WriteLine(" Grade E : ");
            }

           else
            {
                Console.WriteLine(" Grade F(fail) : ");
            }

            Console.ReadLine();



        }
    }
}
