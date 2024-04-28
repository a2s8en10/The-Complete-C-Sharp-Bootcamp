using System;

namespace TRY_WITH_MULTIPLE_CATCH_BLOCKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 12;  // first exception are solve then next exception are solve
                int b = 0;
                int c = a / b;

                string name = null;
                Console.WriteLine(name.Length);

                int[] num = new int[3];
                num[0] = 1;
                num[1] = 2;
                num[2] = 3;
                num[3] = 4;

            }
            catch (DivideByZeroException ex )
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
