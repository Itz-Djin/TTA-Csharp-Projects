using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console App Part One Assignment
        // Creates array cars
        string[] cars = { "Honda", "Toyota", "Ford", "Porche", "Nissan", "Volkswagen" };

        Console.WriteLine("If you could give a name to a vehicle within a brand what would it be?");
        // assigns user input value to string userName
        string userName = Console.ReadLine();

        // Iterates through each string in cars and appends a space and users input
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = cars[i] + " " + userName;
        }
        // Iterates through cars and prints each individual one to console
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
        Console.ReadLine();


        // Console App Part Two Assignment
        bool infinite = false;
        // While infinite not false (true) perform code
        while (!infinite)
        {
            // Writes "Infinite loop" once, turns the bool 'infinite' to true, ending the program.
            Console.WriteLine("Infinte loop");
            infinite = true;
            Console.ReadLine();
        }


        // Console App Part Three Assignment
        Console.WriteLine("Please give input a number between 1 and 25.");
        int userNum = Convert.ToInt32(Console.ReadLine());

        // Iterates through, if i is less than userNum, increment by 1 till it reaches userNum
        for (int i = 0; i < userNum; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
        // In this for loop, it will include the number from userNum opposed to being one less like the for loop above.
        for (int i = 0; i <= userNum; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();


        //Console App Part Four Assignment
        List<string> companies = new List<string> { "apple", "facebook", "google", "amazon", "adobe", "microsoft", "ubisoft", "astro" };
        
        Console.WriteLine("Please input a company you are searching for.");
        string userSearch = Console.ReadLine();
        //Converts userSearch to all lowercase
        string userSearchLow = userSearch.ToLower();
        //Sets index val to 0
        int val = 0;
        bool idk = false;

        //While idk not false (true)
        while(!idk)
        {
            //sets company variable for each item within companies
            foreach (string company in companies)
            {
                //if user input matches a company the index of that value is given
                if (company == userSearchLow)
                {
                    Console.WriteLine(val);
                    idk = true;
                }
                //allows iteration through companies
                val++;
            }
            //if companies doesn't have the users search this code block is hit
            if (!companies.Contains(userSearchLow))
            {
                Console.WriteLine("The company you are searching for doesn't exist. Try Again.");
                userSearch = Console.ReadLine();
                userSearchLow = userSearch.ToLower();
                //resets val to 0
                val = 0;
            }

        }


        // Console App Part Five Assignment
        List<string> colors = new List<string> { "blue", "green", "yellow", "orange", "silver", "green" };

        Console.WriteLine("Please search for a color.");
        string userColor = Console.ReadLine();

        //creates for loop to iterate through colors
        for (int i = 0; i < colors.Count; i++)
        {
            //if user gives a valid color within colors list, the index is returned
            if (userColor == colors[i])
            {
                Console.WriteLine(i);
            }
        }
        //if the user gives an invalid color this block of code is hit
        if (!colors.Contains(userColor))
        {
            Console.WriteLine("Color doesn't exist.");
        }
        Console.ReadLine();

        // Console App Part Six Assignment
        List<string> tools = new List<string> { "hammer", "screwdriver", "flathead", "drill", "hammer", "compressor", "saw" };
        List<string> dupetools = new List<string>();

        //sets tool variable for each item in tools
        foreach (string tool in tools)
        {
            if (dupetools.Contains(tool))
            {
                Console.WriteLine(tool + " -is a duplicate.");
            }
            //
            else
            {
                Console.WriteLine(tool + " -not a duplicate");
            }
            dupetools.Add(tool);
        }


        Console.ReadLine();
    }
}
