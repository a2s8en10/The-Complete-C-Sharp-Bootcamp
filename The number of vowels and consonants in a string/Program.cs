using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_number_of_vowels_and_consonants_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Length);

            int vowels = 0;

            for (int i = 0; i < str.Length; i++)
            {
               // Console.WriteLine(str[i]);
               
                if ( str[i]=='a' || str[i]=='e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowels++;
                }

            }
            Console.WriteLine("Numner of vowel = " + vowels);
            int consonant = str.Length - vowels; 
            Console.WriteLine("Number of consonants = "+ consonant);
            Console.ReadLine();
        }
    }
}
