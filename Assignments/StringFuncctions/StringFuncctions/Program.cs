using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFuncctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jin";
            //string quote = "The man said, \"Hello\", Jin. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jin";

            //bool trueOrFalse = name.Contains("s");

            //Console.WriteLine(quote);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jin");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
