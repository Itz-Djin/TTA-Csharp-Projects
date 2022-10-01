using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person
    {
        //string properties of Person
        public string firstName { get; set; }
        public string lastName { get; set; }

        //abstract Method to be inherited and overriden
        public abstract void SayName();
    }
}
