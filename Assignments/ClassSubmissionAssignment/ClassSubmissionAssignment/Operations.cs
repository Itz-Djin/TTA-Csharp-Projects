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

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }

}
