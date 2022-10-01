using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int a, b;

            //instantiates Operations class
            Operations op = new Operations();

            Console.WriteLine("Please provide a number for an equation with a divisor of 2.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //calls Divide method and gives the user input as an argument
            op.Divide(num1);

            //calls getValues method
            op.getValues(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of a : {0}", b);

            //calls Mixed class and its method
            Console.WriteLine(Mixed.Addition(5));

            Console.ReadLine();
        }
    }
}
