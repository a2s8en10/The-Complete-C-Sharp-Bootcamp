using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEL_CON__NESTED_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username : ");
            string username = Console.ReadLine();
         
            if (username == "Anuragsahu123")
            {
                Console.Write("Enter your password : ");
                string Password = Console.ReadLine();

                    if (Password ==  "Relaxanurag123@")
                    {
                        Console.WriteLine( "Login successful..");
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect your password... ");
                    }
            }
            else
            {
                Console.WriteLine("Incorrect your username...");
            }
            Console.ReadLine();
        }
    }
}
