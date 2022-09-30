using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want math operations on?");
            //converts userInput into int number
            int number = Convert.ToInt32(Console.ReadLine());

            //creates a int variable for our methods, easier to call upon
            int addition = Math.addition(number);
            int subtraction = Math.subtraction(number);
            int multiplication = Math.multiplication(number);

            Console.WriteLine(number + " + 10 = " + addition);
            Console.WriteLine("10 - " + number + " = " + subtraction);
            Console.WriteLine(number + " * = " + multiplication);
            Console.ReadLine();
        }
    }
}
