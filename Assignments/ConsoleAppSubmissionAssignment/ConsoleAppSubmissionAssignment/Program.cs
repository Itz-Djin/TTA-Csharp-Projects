using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give any number.");
            //Converts user input to int data type
            int i = Convert.ToInt32(Console.ReadLine());

            //while loop where if user input is greater than 1, decrement by 1 till number is reached
            while (i > 1)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.ReadLine();
            //Tries loop once even if false
            do
            {
                Console.WriteLine(i);
                i++;
            }
            //if condition is false than allows increment to occur, if user input is less than 500 increment by 1 till 500
            while (i < 500);
            Console.ReadLine();
        }
    }
}
