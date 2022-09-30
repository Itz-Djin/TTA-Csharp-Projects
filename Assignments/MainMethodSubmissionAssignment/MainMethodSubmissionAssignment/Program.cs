using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            decimal num1 = 5.5m;
            string str1 = "10";

            //instantiates our class Operations and assigns it to identifier operations (lower vs upper case "o")
            Operations operations = new Operations();
            //call Addition method of the operations class and number is passed in as the argument
            Console.WriteLine(operations.Addition(number));

            //call Addition method of the operations class and a decimal is passed in as the argument
            Console.WriteLine(operations.Addition(num1));

            //call Addition method of the operations class and a string is passed in as the argument
            Console.WriteLine(operations.Addition(str1));
            


            Console.ReadLine();
        }
    }
}
