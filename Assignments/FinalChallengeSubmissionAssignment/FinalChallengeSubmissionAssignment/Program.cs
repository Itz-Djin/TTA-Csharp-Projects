using FinalChallengeSubmissionAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Dalton" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
