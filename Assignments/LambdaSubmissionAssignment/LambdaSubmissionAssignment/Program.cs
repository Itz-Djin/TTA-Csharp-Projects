using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Kron" },
                new Employee() { Id = 2, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 3, FirstName = "Katt", LastName = "Brady" },
                new Employee() { Id = 4, FirstName = "Vai", LastName = "Guy" },
                new Employee() { Id = 5, FirstName = "Jin", LastName = "Kron" },
                new Employee() { Id = 6, FirstName = "Sally", LastName = "Kron" },
                new Employee() { Id = 7, FirstName = "Adam", LastName = "Kron" },
                new Employee() { Id = 8, FirstName = "Spencer", LastName = "Kron" },
                new Employee() { Id = 9, FirstName = "Scott", LastName = "Kron" },
                new Employee() { Id = 10, FirstName = "Jay", LastName = "Kron" }
            };

            List<Employee> listOfJoes = new List<Employee>();

            //creates employee variable of employees
            foreach (Employee employee in employees)
            {
                //if "Joe" is found in employee
                if(employee.FirstName == "Joe")
                {
                    //add "Joe" to listOfJoes
                    listOfJoes.Add(employee);
                }

            }
            foreach (Employee joe in listOfJoes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }
            Console.ReadLine();

            //goes through list of employees and adds to listOfJoes2,
            //if the name "Joe" is found in employees
            List<Employee> listOfJoes2 = employees.Where(n => n.FirstName == "Joe").ToList();
            foreach (Employee joe2 in listOfJoes2)
            {
                Console.WriteLine(joe2.FirstName + " " + joe2.LastName);
            }
            Console.ReadLine();

            //iterates through empId, finds Id's over 5
            //adds those over 5 to idOver5
            List<Employee> idOver5 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee id in idOver5)
            {
                Console.WriteLine(id.Id + " " + id.FirstName);
            }

            Console.ReadLine();
        }
    }
}
