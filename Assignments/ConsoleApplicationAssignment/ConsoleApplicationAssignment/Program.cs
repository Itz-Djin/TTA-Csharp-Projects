using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            //the best option to convert the users input from a string to a int data type
            int userInput = Convert.ToInt32(Console.ReadLine());
            //string userInput = Console.ReadLine();
            //int userNumber = Convert.ToInt32(userInput);
            //int times50 = userNumber * 50;
            //instead of creating two int data types where one is converting the string userInput,
            //below combines that action into one int data type. lets see if we can go further.
            int times50 = 50 * userInput;
            int add25 = 25 + userInput;
            bool great50 = userInput > 50;
            int div7 = userInput / 7;
            Console.WriteLine(userInput + " multiplied by 50 = " + times50);
            Console.WriteLine(userInput + " added to 25 = " + add25);
            Console.WriteLine("is " + userInput + " greater than 50: " + great50);
            Console.WriteLine(userInput + " divided by 7 = " + div7);
            Console.ReadLine();
        }
    }
}
