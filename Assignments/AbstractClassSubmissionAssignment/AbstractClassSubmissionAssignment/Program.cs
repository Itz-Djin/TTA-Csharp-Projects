using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";

            //calls method SayName()
            emp.SayName();
            Console.ReadLine();
        }
    }
}
