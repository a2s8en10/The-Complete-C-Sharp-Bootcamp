using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first dioagonal lenght : ");
            float p =  float.Parse(Console.ReadLine());

            Console.Write("Enter the second diagonal length : ");
            float q = float.Parse(Console.ReadLine());

            float area=(p*q)/2;

            Console.Write("Area of Rhombus is : " +  area);
            Console.ReadLine();


        }
    }
}