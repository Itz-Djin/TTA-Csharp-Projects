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
            List<string> employees = new List<string>()
            {
                "Joe",
                "James",
                "Adam",
                "Leeya",
                "Joe",
                "Jin",
                "Serena",
                "Rich",
                "Henry",
                "Silvester"
            };

            //List<string> listOfJoes = new List<string>();

            //foreach (string employee in employees)
            //{
            //    if(employee == "Joe")
            //    {
            //        listOfJoes.Add(employee);
            //    }

            //}
            //Console.WriteLine(listOfJoes);

            var listOfJoes2 = employees.Where(n => n == "Joe");
            Console.WriteLine(listOfJoes2);
            Console.ReadLine();
        }
    }
}
