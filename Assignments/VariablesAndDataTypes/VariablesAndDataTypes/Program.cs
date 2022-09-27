using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            // Practicing casting data types,
            // remember casting is converting one data type to another.
            // This is need in C# because it is a strict language, 
            // meaning you have to specify the exact data type you are using when giving it a value
            // example: if using a number you have to use a data type that utilizes integers
            // or if using a string you have to use double parantheses
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            // boolean (bool in C#) is true or false
            bool isStudying = false;
            // byte is 0 - 255
            byte hoursWorked = 42;
            // sbye is -amount to positive amount
            sbyte currentTemperature = -23;
            // char is any unicode character, needs single quotes
            char questionMark = '\u2103';
            // decimal is used for decimal numbers, best for financial transactions, needs suffix m to identify its decimal
            decimal moneyInBank = 10.5m;
            // double is commonly used when using decimal values
            double heightInCentimers = 211.30303092;
            // another commonly used data type when dealing wiht decimal values
            float secondsLeft = 2.62f;
            // short is used for smaller interger values
            short temperatureOnMars = -341;

            // give integer value to currentAge
            int currentAge = 30;
            //converts the integer value given in currentAge to a string
            string yearsOld = currentAge.ToString();

            // states that it is raining
            bool isRaining = true;
            // converts the bool value of true to string
            string rainingStatus = Convert.ToString(isRaining);
            // allows that true to be printed
            Console.WriteLine(rainingStatus);
            Console.ReadLine();





        }
    }
}
