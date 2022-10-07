using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a variable that cannot be changed
            const string slcVinylCo = "SLCVinylCo";
            //using var to create a variable, var implicitly detects what the value is
            var x = 369;
        }
        //creating new class
        public class People
        {
            public string name;
            public int age;

            //chaining constructors 
            //inherits from other People constructor but defaults age to 18
           public People(string name) : this(name, 18)
            {

            } 
           public People(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
