using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num = 1;
            Console.WriteLine(num);
            Console.ReadLine();

        }
        public struct Number
        {
            public decimal Amount { get; set; }

        }
    }
}
