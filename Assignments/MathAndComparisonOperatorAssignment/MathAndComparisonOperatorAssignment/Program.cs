using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1
            Console.WriteLine("Person 1");
            //Hourly rate
            Console.WriteLine(" Enter hourly rate: ");
            //obtains user input for their hourly rate. it takes the string value and converts it into a decimal then assigns the value to p1Rate
            decimal p1Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" Enter hours worked per week");
            //obtains user input for hours worked. inputed as a string then converted to int value assigned to p1Hours
            int p1Hours = Convert.ToInt32(Console.ReadLine());
            //Determines annual salary for Person 1
            decimal p1Salary = p1Rate * p1Hours * 52;

            //Person 2
            Console.WriteLine("Person 2");
            //Hourly rate
            Console.WriteLine(" Enter hourly rate: ");
            //Same as from p1 but for p2
            decimal p2Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" Enter hours worked per week");
            int p2Hours = Convert.ToInt32(Console.ReadLine());
            //Determines annual salary for Person 2
            decimal p2Salary = p2Rate * p2Hours * 52;

            //Displays salary of Person 1, pauses, then Person 2
            Console.WriteLine("Annual salary of Person 1: " + p1Salary);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2: " + p2Salary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryComparison = p1Salary > p2Salary;
            Console.WriteLine(salaryComparison);
            Console.ReadLine();
        }
    }
}
