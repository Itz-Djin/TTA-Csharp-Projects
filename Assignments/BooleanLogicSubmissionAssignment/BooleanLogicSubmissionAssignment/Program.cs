using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Application");
            Console.ReadLine();

            // qualifying questions
            Console.WriteLine("What is your age?");
            //Converts string value given to an int value
            int age = Convert.ToInt32(Console.ReadLine());
            //Converts string value given to a boolean value
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\" ");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            //Converts string value given to a int value
            Console.WriteLine("How many speeding tickets do you have? Please use integer number.");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Determines if person is qualified, they must meet all 3 given criteria
            bool qualified = age > 15 && DUI == false && tickets < 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
