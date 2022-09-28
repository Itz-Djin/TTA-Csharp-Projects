using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Arrays are used when you have a fixed quantity of people, or if you're storing a very large quantity of something
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Jin");
        intList.Remove("Jin");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        ////initializes numArray with 5 indices
        //int[] numArray = new int[5];
        ////instantiates numArrays indices 0-5 with set values
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////exact same thing as numArray but more consolidated
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 500 };

        ////Even faster/better way
        //int[] numArray2 = { 5, 2, 10, 200, 500, 600, 2300 };

        ////Changes the value at index 5 of numArray2
        //numArray2[5] = 650;

        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

