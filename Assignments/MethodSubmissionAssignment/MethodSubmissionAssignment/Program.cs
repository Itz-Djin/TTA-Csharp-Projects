using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates Operations class as operations object
            Operations operations = new Operations();
            Console.WriteLine("Please provide a number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("optional: Provide another number.");
                int input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(operations.Multiplication(input1, y: input2));
            }
            catch
            {
                Console.WriteLine(operations.Multiplication(input1));
            }
            //Console.WriteLine("optional: Provide another number.");
            //int input2 = Convert.ToInt32(Console.ReadLine());

            //passed two arguments of user input
            //Console.WriteLine(operations.Multiplication(input1, y: input2));

            Console.ReadLine();
        }
    }
}
