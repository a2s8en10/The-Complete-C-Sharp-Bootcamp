using System;

namespace FINALLY_BLOCK_WITH_TRY_CATCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = null;
                Console.WriteLine(a.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally         // finally block are always execute
            {
                Console.WriteLine("finally block are execute...");
            }
            Console.ReadLine();
        }
    }
}
