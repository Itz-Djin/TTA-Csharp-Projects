using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates variables
            int num1 = 1;
            int num2 = 2;

            //instantiates Operations class
            Operations operations = new Operations();
            //calls Addition() of operations, giving two arguments
            operations.Addition(num1, num2);
            //calls method in class specifying parameters by name
            operations.Addition(x: num1, y: num2);

            Console.ReadLine();
        }
    }
}
