using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTIAL_RULE
{
    public partial class partial_student : myclass  // inherit the main class and use method
    {
        private string fname; // inside the show method
    }

    // abstract class
    //class student : partial_student
    //{
    //    public int roll;
    //    public int fees;
    //    public override void detail()
    //    {
    //        Console.WriteLine("id is :" + this.id);
    //        Console.WriteLine("name is :" + this.name);
    //        Console.WriteLine("roll is :" + this.roll);
    //        Console.WriteLine("fees is :" + this.fees);
    //    }
    //}

}
