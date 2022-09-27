using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the school as well as what this page is
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            // Displays the given question
            Console.WriteLine("What is your name?");
            // Reads what name was given in the question and assigns it to the string firstName
            string firstName = Console.ReadLine();
           // Console.WriteLine("Your name is: " + firstName);

            // Displays the given question
            Console.WriteLine("What course are you on?");
            // Reads answer given and assigns it to the string course
            string course = Console.ReadLine();
            //Console.WriteLine("You are on the: " + course);

            // Displays the given question
            Console.WriteLine("What page number?");
            // Assigns the value given as a string to pageNumber
            string pageNumber = Console.ReadLine();
            // Converts the string pageNumber to a int data type
            int pgNumber = Convert.ToInt32(pageNumber);
            //Console.WriteLine("You are on page: " + pgNumber);

            // Displays given question to console
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            // converts the string needHelp to bool Help
            bool Help = Convert.ToBoolean(needHelp);

            // Displays question 
            Console.WriteLine("Were there any positive experienced you\'d like to share? Please give specifics.");
            //Assigns value given from question to string experiencesShared
            string experiencesShared = Console.ReadLine();

            // Displays question
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            // Assings value from question to string feedback
            string feedback = Console.ReadLine();
            
            //Displays question
            Console.WriteLine("How many hours did you study today?");
            // Assigns value from question to string hourStudied
            string hoursStudied = Console.ReadLine();
            // Converts hourStudied string to an integer value
            int hrsStudied = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
