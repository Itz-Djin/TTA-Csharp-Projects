using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter current day of the week.");
                string entry = Console.ReadLine();
                //parses through DaysOfWeek and string entry compares for a match
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), entry);
                Console.WriteLine(day);

            }
            //If user inputs anything other than a valid entry, exception is caught
            catch (Exception)
            {

                Console.WriteLine("Please enter the actual day of the week.");
            }

            //DaysOfWeek.Days entry;
            //entry = Console.ReadLine();
            //string entry = Console.ReadLine();
            //Console.WriteLine(entry);
            //DaysOfWeek.Days entry = DaysOfWeek.Days.Friday;

            //Console.WriteLine((int)entry);
            Console.ReadLine();

        }
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
