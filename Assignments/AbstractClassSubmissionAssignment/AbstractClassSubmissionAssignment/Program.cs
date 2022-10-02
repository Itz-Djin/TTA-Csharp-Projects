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
            //instanties Employee class as emp
            Employee emp = new Employee();
            //assigns first name "Sample" and last name "Student"
            emp.firstName = "Sample";
            emp.lastName = "Student";

            //calls method SayName()
            emp.SayName();
            Console.ReadLine();

            //Polymorphism submission assignment
            IQuittable emp1 = new Employee();
            emp1.Quit(emp);
            Console.ReadLine();
        }
    }
}
