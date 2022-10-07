using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                //converts user input to date type int
                int userAge = Convert.ToInt32(Console.ReadLine());
                //creates int data type with the value of todays year (int)
                int thisYear = DateTime.Now.Year;
                //subtracts this year from users input to output roughply the year they were born
                int DOB = thisYear - userAge;
                Console.WriteLine(DOB);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter digits only, no decimal, zero, or negative numbers.");
            }
            

            Console.ReadLine();
        }
    }
}
