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
            //Console.WriteLine("Please Provide a number");
            int number = 5;
            int addition = Operations.addition(number);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
