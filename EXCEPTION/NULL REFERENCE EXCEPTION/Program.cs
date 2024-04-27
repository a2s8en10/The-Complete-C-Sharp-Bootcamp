
using System;

namespace NULL_REFERENCE_EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                Console.WriteLine(name);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("string is null");
            }

            Console.ReadLine();
        }
    }
}
