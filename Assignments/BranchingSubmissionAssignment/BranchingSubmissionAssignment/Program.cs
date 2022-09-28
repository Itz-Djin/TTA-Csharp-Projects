using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight?");
            //Converts user input value to int data type
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            //if package weight is greater than 50 end program (return), otherwise continue 
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            //Converts package width to int data type
            Console.WriteLine("Please enter the package width?");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            //Converts package height to int data type
            Console.WriteLine("Please enter the package height?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            //Converts package lengt to int data type
            Console.WriteLine("Please enter the package length?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            //multiplies package width, height and length, if product of that is less than 50 proceed, if not end program
            if (pkgWidth * pkgHeight * pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            //Creates the quote if package meets all above requirements
            int quote = (((pkgWidth * pkgHeight * pkgLength) * pkgWeight) / 100);
            Console.WriteLine("$" + Convert.ToString(quote) + ".00");

            Console.ReadLine();
        }
    }
}
