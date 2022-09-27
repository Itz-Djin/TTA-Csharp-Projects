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
            int num1 = 20;
            int num2 = 30;
            int num3 = 40;
            Console.WriteLine("Num1 is: " + num1 + " Num2 is: " + num2 + " num3 is: " + num3);
            int sum = num1 + num2;
            Console.WriteLine("The sum of the 2 numbers is: " + sum);
            Console.ReadLine();

            int difference = num2 - num1;
            Console.WriteLine("The difference between num1 and num2 is: " + difference);
            Console.ReadLine();

            int product = num1 * num2;
            Console.WriteLine("The product of num1 and num2 is: " + product);
            Console.ReadLine();

            int quotient = num3 / num1;
            Console.WriteLine("The quotient of num3 by num1 is: " + quotient);
            Console.ReadLine();
        }
    }
}
