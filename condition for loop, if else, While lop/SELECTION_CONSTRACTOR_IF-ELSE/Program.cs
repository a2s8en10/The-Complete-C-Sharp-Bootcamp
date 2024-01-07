using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECTION_CONSTRACTOR_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EXAMPLE 1:-

            /*  Console.Write("Enter The Number : ");
              int a = int.Parse(Console.ReadLine());*/

            /* Console.Write("Enter The Compair Number : ");
             int n = int.Parse(Console.ReadLine());*/

            /* if (a > 10)
             {
                 Console.Write("This is Greter then");
             }
             else
             {
                 Console.Write("This is lasser");
             }
             Console.ReadLine();*/

            // EXAMPLE 2:-
             /*Console.Write("Enter The Username: ");
             string a = Console.ReadLine();
 
            if (a == "Anurag")
            {
                Console.WriteLine("Welcome 'Anurag'");
            }
            else
            {
                Console.WriteLine("Who are you ?");
           }
           Console.ReadLine();*/

            //EXAMPLE 3:-

            Console.Write("Enter The Usernames: ");
            string username= Console.ReadLine();

            Console.Write("Enter The Password: ");
            string password = Console.ReadLine();

            if (username == "Relax.Anurag"  &&  password == "Relax123")
            {
                Console.WriteLine("Login sucsesfull... ");
            }

            else
            {
                Console.WriteLine("Userename And Password incorrect...")
            }

            Console.ReadLine();

        }
    }
}
