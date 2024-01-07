using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_non_matching_characters_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st string :");
            string str = Console.ReadLine();
            Console.WriteLine(str.ToLower());

            Console.WriteLine("Enter the 2nd string :");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1.ToLower());

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                //Console.WriteLine(str[i]);

                for (int j = 0; j < str1.Length; j++)
                {
                    //Console.WriteLine(str1[j]);

                    if (str[i] == str1[j])
                    {
                        count++;
                        
                    }
                    
                }
              
            }  
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
