using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTIAL
{
    internal partial class student
    {
        private string fname;
        private string lname;

        public string Firtstname
        {
            set { fname = value; }
            get { return fname; }
        }
        public string Lastname
        {
            set { lname = value; }
            get { return lname; }
        }
    }
}
