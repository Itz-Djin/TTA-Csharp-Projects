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

            //does the second Additon method (decimal) of the operations class,
            //converts result to int and assigns to intNum1
            //int intNum1 = Convert.ToInt32(operations.Addition(num1));
            //Console.WriteLine(intNum1);
            Console.WriteLine(operations.Addition(num1));

            Console.WriteLine(operations.Addition(str1));



            Console.ReadLine();
        }
    }
}
