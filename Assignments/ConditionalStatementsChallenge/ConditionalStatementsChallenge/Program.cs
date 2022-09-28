using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            if(favNum > 5)
            {
                Console.WriteLine("Your favorite number is greater than 5");
            }
            else if(favNum < 5)
            {
                Console.WriteLine("Your favorite number is less than 5");
            }
            else if(favNum == 5)
            {
                Console.WriteLine("5 is a great number");
            }
            else
            {
                Console.WriteLine("Please provide a numerical value not a string value");
            }
            Console.ReadLine();
        }
    }
}
