using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Operations
    {
        public void Divide(int x)
        {
            //creates our operation and assings the end value to identifier result
            int result = x / 2;
            Console.WriteLine(result);

            Console.ReadLine();
        }

        //overloading Divide method
        public void Divide(byte x, byte y)
        {
            int result = x + y;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //method with output parameters
        public void getValues(out int x, out int y)
        {
            //takes user input and assigns value to x
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            //takes user input and assigns value to y
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

    }

}
