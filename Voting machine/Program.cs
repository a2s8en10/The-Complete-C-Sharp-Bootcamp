using System;

namespace Voting_machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age : ");
            int age = int.Parse(Console.ReadLine());
             
            if (age >= 18)
            {
                Console.WriteLine("you are available in Voting");
            }
            else
            {
                Console.WriteLine("you are not available in Voting");
            }
            Console.ReadLine();
        }
    }
}
