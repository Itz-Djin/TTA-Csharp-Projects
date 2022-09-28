using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creates string array fruitsArray
        string[] fruitsArray = { "Apple", "Orange", "Banana", "Mango", "Guava" };
        //Asks user input
        Console.WriteLine("Please select an index value up to 4.");
        //Converts user input to int data type
        int indValue = Convert.ToInt32(Console.ReadLine());

        //if user input is greater than or equal to 5, console replies index invalid and closes
        if (indValue >= 5)
        {
            Console.WriteLine("The index you have chosen doesn't exist.");
        }
        //if user input is less than 5 commits else
        else
        {
            //Takes user inputted index and displays string at that position
            Console.WriteLine(fruitsArray[indValue]);
            Console.ReadLine();
        }

        //Creates an int array 
        int[] intArray = { 4, 5, 7, 32, 53, 66 };
        Console.WriteLine("Please select an index value up to 5.");
        //Converts user value into integer data type
        int userIndex = Convert.ToInt32(Console.ReadLine());
        //sets userVal to false
        bool userVal = false;

        //while user value is not false commit block of code
        while (!userVal)
        {
            //if userIndex is greater than or equal to 6 OR userIndex is less than 0 commit code
            if (userIndex >= 6 || userIndex < 0)
            {
                Console.WriteLine("Index Invalid, please try again.");
                userIndex = Convert.ToInt32(Console.ReadLine());
            }
            //if userIndex between 6 and 0 (including 0) commit this block of code
            else
            {
                //displays value at users chosen index
                Console.WriteLine("The value at the index you have selected is: " + intArray[userIndex]);
                userVal = true;
                Console.ReadLine();
            }
        }

        //Created list of strings
        List<string> cdList = new List<string>();
        //adds cds to the cdList
        cdList.Add("Kronos");
        cdList.Add("Vacation in Hell");
        cdList.Add("Darkside of the Moon");
        cdList.Add("Madvillainy");
        cdList.Add("INSIDE");

        Console.WriteLine("Please select and index value up to 4.");
        int cdIndex = Convert.ToInt32(Console.ReadLine());

        bool cdVal = false;

        //cdVal set to not false (true) so while loop commits
        while (!cdVal)
        {
            // if cdIndex is less than 0 OR greater than or equal to 5 repeat loop
            if (cdIndex < 0 || cdIndex >= 5)
            {
                Console.WriteLine("Invalid index, please try again.");
                cdIndex = Convert.ToInt32(Console.ReadLine());
            }    
            //if cdIndex meets criteria, return value at given index
            else
            {
                Console.WriteLine("The cd at the index you have chose is: " + cdList[cdIndex]);
                cdVal = true;
            }    
        }    

        Console.ReadLine();
    }
}
