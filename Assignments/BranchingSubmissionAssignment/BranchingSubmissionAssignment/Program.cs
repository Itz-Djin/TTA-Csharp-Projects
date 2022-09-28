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
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width?");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            if (pkgWidth * pkgHeight * pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            int quote = (((pkgWidth * pkgHeight * pkgLength) * pkgWeight) / 100);
            Console.WriteLine("$" + Convert.ToString(quote) + ".00");

            Console.ReadLine();
        }
    }
}
