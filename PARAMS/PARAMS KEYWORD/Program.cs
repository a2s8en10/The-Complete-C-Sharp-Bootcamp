using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMS_KEYWORD
{
    internal class Program
    {
        public static int add(params int[] nums)
        {
            int sums = 0;
            foreach (int i in nums)
            {
                sums = sums + i;
            }
            return sums;

        }
        static void Main(string[] args)
        {
            // without params keyword
            // int [] arr = {1,212,3,2,3,32};
            // Console.WriteLine(Program.add(arr));
            Console.WriteLine(Program.add(12,12,21313,3,4,3,3));
            Console.ReadLine();
        }
    }
}
