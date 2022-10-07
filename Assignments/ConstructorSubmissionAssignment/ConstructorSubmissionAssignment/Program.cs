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

            //person1 uses overloaded constructor with defualt parameter for age
            People person1 = new People("Jay");

            //person2 uses original constructor with two parameters
            People person2 = new People("Joe", 20);
            Console.WriteLine("{0} is {1} years old, while {2} is {3} years old.", person1.name, person1.age, person2.name, person2.age);
            Console.ReadLine();
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
