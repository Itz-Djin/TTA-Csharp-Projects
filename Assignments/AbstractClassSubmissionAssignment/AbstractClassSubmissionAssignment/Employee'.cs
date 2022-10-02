using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person, IQuittable
    {
        //inherits abstract SayName() and overides it
        public override void SayName()
        {
            //creates string FullName that includes first and last name variables
            string FullName = firstName + " " + lastName;
            //writes employees full name
            Console.WriteLine("Name: {0}", FullName);
        }

        public void Quit(Employee employee)
        {
            Employee employee1 = new Employee();
            //employee1.firstName = "Sample1";
            //employee.lastName = "Studen1";
            string FullName = firstName + " " + lastName;
            Console.WriteLine("Employee: {0}, has quit", FullName);
        }
    }
}
