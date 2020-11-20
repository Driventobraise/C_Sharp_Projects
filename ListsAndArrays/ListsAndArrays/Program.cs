using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // String Array
        string[] strArray = { "Cat", "Dog", "Mouse", "Bat", "Dragon" };
        Console.WriteLine("Please enter an index of the Array to display...");
        int userIndex = Convert.ToInt32(Console.ReadLine());
        if (userIndex >= 5 | userIndex < 0)
        {
            Console.WriteLine("Please enter an index between 4 and 0..\nHit enter to continue..");
            Console.ReadLine();
            Console.WriteLine("Please enter an index of the Array to display...");
            userIndex = Convert.ToInt32(Console.ReadLine());
            // handling the user input if it is out parameters
            if (userIndex <= 4 | userIndex >= 0)
            {
                Console.WriteLine("The data stored at index " + userIndex + " is " + strArray[userIndex]);
                Console.ReadLine();
            }
        }
        else if (userIndex <= 4 | userIndex >= 0)
        {
            Console.WriteLine("The data stored at index " + userIndex + " is " + strArray[userIndex]);
            Console.ReadLine();
        }

        // Interger Array
        int[] intArray = { 5, 100, 69, 503, 206 };
        Console.WriteLine("Please enter an index of the Array to display...");
        int userIndex2 = Convert.ToInt32(Console.ReadLine());
        // handling the user input if it is out parameters
        if (userIndex2 >= 5 | userIndex2 < 0)
        {
            Console.WriteLine("Please enter an index between 4 and 0..\nHit enter to continue..");
            Console.ReadLine();
            Console.WriteLine("Please enter an index of the Array to display...");
            userIndex2 = Convert.ToInt32(Console.ReadLine());
            if (userIndex2 <= 4 | userIndex2 >= 0)
            {
                Console.WriteLine("The data stored at index " + userIndex2 + " is " + intArray[userIndex2]);
                Console.ReadLine();
            }
        }
        else if (userIndex2 <= 4 | userIndex2 >= 0)
        {
            Console.WriteLine("The data stored at index " + userIndex2 + " is " + intArray[userIndex2]);
            Console.ReadLine();
        }

        // String List
        var stringList1 = new List<string>() { "Cat", "Dog", "Mouse", "Bat", "Dragon" };
        Console.WriteLine("Please enter an index of the Array to display...");
        int userIndex3 = Convert.ToInt32(Console.ReadLine());
        if (userIndex3 >= 5 | userIndex3 < 0)
        {
            Console.WriteLine("Please enter an index between 4 and 0..\nHit enter to continue..");
            Console.ReadLine();
            Console.WriteLine("Please enter an index of the Array to display...");
            userIndex3 = Convert.ToInt32(Console.ReadLine());
            // handling the user input if it is out parameters
            if (userIndex3 <= 4 | userIndex3 >= 0)
            {
                Console.WriteLine("The data stored at index " + userIndex3 + " is " + stringList1[userIndex3]);
                Console.ReadLine();
            }
        }
        else if (userIndex3 <= 4 | userIndex3 >= 0)
        {
            Console.WriteLine("The data stored at index " + userIndex3 + " is " + stringList1[userIndex3]);
            Console.ReadLine();
        }

    }
}

