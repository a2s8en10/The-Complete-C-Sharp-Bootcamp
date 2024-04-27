
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
                Console.WriteLine(name.Length);
            }
            catch(NullReferenceException Ex)
            {
                Console.WriteLine("string is null");
                Console.WriteLine(Ex.Message);
            }
            Console.ReadLine();
        }
    }
}
