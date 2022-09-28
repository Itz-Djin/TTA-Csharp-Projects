using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give any number.");
            int i = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 500);
            Console.ReadLine();
        }
    }
}
