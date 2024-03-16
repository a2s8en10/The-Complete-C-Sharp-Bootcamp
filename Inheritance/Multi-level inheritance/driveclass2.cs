using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_level_inheritance
{
    internal class driveclass2 : driveclass1
    {
        public void sub()
        {
            Console.WriteLine("second class");
        }
    }
}
