using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculate_the_number_of_vowels_and_consonants_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter the string value : ");
            //    string value = Console.ReadLine();
            //    Console.WriteLine(value);

            //    string vowels();
            //    string a = " ";
            //    string e = " ";
            //    string i = " ";
            //    string o = " ";
            //    string u = " ";
            //    string consonants = " ";

            //    for (int j = 0; j < value.Length; j++)
            //    {
            //        if (value == a)
            //        {
            //            Console.WriteLine(a);
            //        }
            //        else if ((value == e) || (value == i) || (value == o) || (value == u)) ;
            //        {
            //            Console.WriteLine(e,i,o,);
            //        }
            //        else 
            //        {
            //            Console.WriteLine(value == consonants);
            //        }
            //    }

            //    Console.ReadLine();

            int vowel = 0;
            int consonant = 0;

            string a = " ";
            string e = " ";
            string i = " ";
            string o = " ";
            string u = " ";

            string str = "aryan";

            Console.WriteLine(str);

            for (int j = 1; j < str.Length; j++)
            {

                if (str[j] == a)
                    vowel++;

                else if (str == e)
                    vowel++;

                else if (str == i)
                    vowel++;

                else if (str == o)
                    vowel++;

                else if (str == u)
                    vowel++;

                else
                {
                    consonant = str.Length - vowel;
                }

            }

            Console.WriteLine(vowel);
            Console.WriteLine(consonant);

            Console.ReadLine();


        }
    }
}
