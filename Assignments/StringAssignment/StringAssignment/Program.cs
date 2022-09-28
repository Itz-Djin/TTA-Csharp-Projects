using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite food. Please give a single word answer");
            string favFood = Console.ReadLine();

            Console.WriteLine("What city do you want to visit most?");
            string cityVisit = Console.ReadLine();

            // Create a StringBuilder that expects to hold 500 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder sb = new StringBuilder("ABC", 500);

            // Append three characters ('D', 'E', 'F') to the end of the StringBuilder.
            sb.Append(new char[] { 'D', 'E', 'F' });

            // Append a format string to the end of the StringBuilder.
            sb.AppendFormat("GHI{0}{1}", 'J', 'K');

            //Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            // Insert a string at the beginning of the StringBuilder
            sb.Insert(0, "Alphabet: ");

            // Replace all lowercase k's with uppercase K's
            sb.Replace('k', 'K');

            //Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            Console.WriteLine(name + "s favorite food is " + favFood + ". And they would like to visit " + cityVisit.ToUpper() + " someday");

            Console.ReadLine();
        }
    }
}
