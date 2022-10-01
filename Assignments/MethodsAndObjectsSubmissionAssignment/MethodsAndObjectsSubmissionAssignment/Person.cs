using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    class Person
    {
        //creates properties of Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //creates method that displays first and last name
        public void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: {0}", FullName);
        }
    }
}
