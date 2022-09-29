using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            //List<int> quotients = new List<int>();

            Console.WriteLine("Please provide a number.");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //creates a number variable for each element within numbers
            foreach (int number in numbers)
            {
                int result = number / divisor;
                Console.WriteLine(result);
                //quotients.Add(result);
            }
            //foreach (int quotient in quotients)
            //{
            //    Console.WriteLine(quotient);
            //}
        }
        //if a format errors occurs hit this block of code
        catch (FormatException)
        {
            Console.WriteLine("Please use a numerical value.");
        }
        //if user divides by 0, an error occurs, but this block of code is printed
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please don't use zero.");
        }
        //notifies user has emerged out of the try/catch block and continues with program
        finally
        {
            Console.WriteLine("You have passed the try/catch block, continuing program.");
        }

        Console.ReadLine();
    }
}
