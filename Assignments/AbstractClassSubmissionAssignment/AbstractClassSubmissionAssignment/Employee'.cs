﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            string FullName = firstName + " " + lastName;
            Console.WriteLine("Name: {0}", FullName);
        }
    }
}
