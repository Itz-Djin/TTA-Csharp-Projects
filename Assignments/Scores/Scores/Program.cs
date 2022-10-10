using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.Write(msg);

            //path to file containing scores
            string path = @"F:\The Tech Academy\TTA-Csharp-Projects\Assignments\Scores\Scores\studentScores.txt";
            //creates array storing data from txt file as lines 
            string[] lines = System.IO.File.ReadAllLines(path);

            //setting variable of total score to 0.0
            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                //referencing each line as a score
                Console.WriteLine("\n" + line);
                //changing the data type from text file, og file is strings
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotel of " + lines.Length + " studen scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
