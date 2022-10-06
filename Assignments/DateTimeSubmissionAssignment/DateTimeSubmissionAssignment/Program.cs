using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("hh:mm tt"));
            Console.WriteLine("Please enter a number.");
            Double x = Convert.ToDouble(Console.ReadLine());
            DateTime later = DateTime.Now.AddHours(x);
            Console.WriteLine(later.ToString("hh:mm tt"));
            Console.ReadLine();
        }
    }
}
