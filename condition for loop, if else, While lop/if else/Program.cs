using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());


            if (a == b)
            {
                Console.WriteLine("{0} and {1} Are equal.", a, b);
            }
            else
            {
                Console.WriteLine("{0} and {1} Are not Equal.", a, b);
            }

            Console.WriteLine("Enter the number:");
            int c = int.Parse(Console.ReadLine());

            int num = c % 2;

            if (num == 0)
            {
                Console.WriteLine("Number Are Even");
            }
            else
            {
                Console.WriteLine("Number Are Odd");
            }

            Console.WriteLine("Enter the number:");
            int d = int.Parse(Console.ReadLine());

            if (0 <= d)
            {
                Console.WriteLine("Number Are Positive");
            }
            else
            {
                Console.WriteLine("Number Are Negetive");
            }

            Console.WriteLine("Enter the Alphabet:");
            char Alpha = char.Parse(Console.ReadLine());

            int i = Alpha;

            switch (i)
            {
                case 'a':
                    Console.WriteLine("This is Vowel Alphabet");
                    break;

                case 'e':
                    Console.WriteLine("This is Vowel Aplhabet");
                    break;

                case 'i':
                    Console.WriteLine("This is Vowel Aplhabet");
                    break;

                case 'o':
                    Console.WriteLine("This is Vowel Aplhabet");
                    break;

                case 'u':
                    Console.WriteLine("This is Vowel Aplhabet");
                    break;

                default:
                    Console.WriteLine("This is constent Alphabet");
                    break;
            }

            Console.WriteLine("Enter number of month : ");
            int j = int.Parse(Console.ReadLine());

            if (j <= 0)
            {
                Console.WriteLine("Year are only 12 Month....");
            }
            else
            {
                switch (j)
                {
                    case 1:
                        Console.WriteLine("31 Days This Month");
                        break;

                    case 2:
                        Console.WriteLine("28 Days This Month ");
                        break;

                    case 3:
                        Console.WriteLine("31 Days This Month");
                        break;

                    case 4:
                        Console.WriteLine("30 Days This Month");
                        break;

                    case 5:
                        Console.WriteLine("31 Days This Month");
                        break;

                    case 6:
                        Console.WriteLine("30 Days This Month");
                        break;

                    case 7:
                        Console.WriteLine("31 Days This Month");
                        break;

                    case 8:
                        Console.WriteLine("31 Days This Month");
                        break;

                    case 9:
                        Console.WriteLine("30 Days This Month");
                        break;

                    case 10:
                        Console.WriteLine("31 Days This Month");
                        break;

                    case 11:
                        Console.WriteLine("30 Days This Month");
                        break;

                    case 12:
                        Console.WriteLine("31 Days This Month");
                        break;

                    default:
                        Console.WriteLine("Days This Month");
                        break;


                }
            }







            Console.ReadLine();
        }
    }
}
