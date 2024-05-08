using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTIAL_RULE
{
        public class myclass
        {
            public void show()
            {

            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            //student obj = new student();
            //obj.fees = 23;
            //obj.name = "Test";
            //obj.roll = 24;
            //obj.id = 1;
            //obj.detail();

            partial_student obj2 = new partial_student();
            obj2.show();
            Console.ReadLine();
        }
    }
}
