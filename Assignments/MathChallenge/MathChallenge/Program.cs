using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 20;
            //int num2 = 30;
            //int num3 = 40;
            //Console.WriteLine("Num1 is: " + num1 + " Num2 is: " + num2 + " num3 is: " + num3);
            //int sum = num1 + num2;
            //Console.WriteLine("The sum of the 2 numbers is: " + sum);
            //Console.ReadLine();

            //int difference = num2 - num1;
            //Console.WriteLine("The difference between num1 and num2 is: " + difference);
            //Console.ReadLine();

            //int product = num1 * num2;
            //Console.WriteLine("The product of num1 and num2 is: " + product);
            //Console.ReadLine();

            //int quotient = num3 / num1;
            //Console.WriteLine("The quotient of num3 by num1 is: " + quotient);
            //Console.ReadLine();

            // Math with diff data types
            int num5 = 7;
            float num6 = 5.5f;
            // what would be the declared data type here
            //??? total = num5 + num2; 
            // it would be a float because it is more specific 
            float total = num5 + num6;
            Console.WriteLine(total);
            Console.ReadLine();
            // however if the total need to be of type "int" then you would have to cast the float 
            int totalInt = num5 + (Int32)num6;
            Console.WriteLine(totalInt);
            Console.ReadLine();

            // performing a math operation on a string
            // a.k.a string concatenation
            // addition is the only operation available to string data types
            Console.WriteLine("Christdjin " + "Brady");
            Console.ReadLine();

        }
    }
}
