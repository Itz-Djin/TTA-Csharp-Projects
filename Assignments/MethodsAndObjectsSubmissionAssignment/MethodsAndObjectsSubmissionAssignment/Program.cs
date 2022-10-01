using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiates Employee class
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";

            //calls method to display First and Last Name
            emp.SayName();
            Console.ReadLine();
        }
    }
}
