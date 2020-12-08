using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking the user for input
            Console.WriteLine("Please enter one Verb...");
            string verb = Console.ReadLine();

            // A one-dimensional array of strings.
            string[] animalActions = { "The Cat ", "The Dog ", "The Mouse " };

            //loop that iterates through each string in the array and adds the user's text input.
            //loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = 0; i < animalActions.Length; i++)
            {
                animalActions[i] = animalActions[i] + verb;
            }
            //loop that prints off each string in the array on a separate line
            foreach (string action in animalActions)
            {
                Console.WriteLine(action + "'s");
            }
            Console.ReadLine();

            //An infinite loop. 
            //int count = 0;

            //while (true)
            //{
            //    Console.WriteLine("Count = {0}.", count);
            //    if (count > 125)
            //    {
            //        break;
            //    }
            //}

            //An infinite loop fixed.
            int count = 0;

            while (true)
            {
                Console.WriteLine("Count = {0}.", count);
                //increase the loop variable (count++) with each loop cycle, the break statement can end the loop after 125 iterations.
                count++;
                if (count > 125)
                {
                    break;
                }
            }
            Console.ReadLine();

            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] <= 60)
                {
                    Console.WriteLine("Failing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();

            //list of strings where each item in the list is unique
            List<string> fruits = new List<string>() { "Apple", "Banana", "Grape", "Strawberry", "Watermelon"};

            //user to input text to search for in the list.
            Console.WriteLine("Name a Fruit...");
            string usersFruit = Console.ReadLine();
            //loop that iterates through the list and then displays the index of the list
            foreach (string fruit in fruits)
            {
               
                if (fruit == usersFruit)
                {
                    int index = fruits.IndexOf(usersFruit);
                    Console.WriteLine(usersFruit + " is at index " + index);
                    
                }
                //loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list
                else if (fruit != usersFruit)
                {
                    Console.WriteLine("Whoops looks like its not on the list try again");
                    Console.WriteLine("Name a Fruit...");
                    string usersFruit2 = Console.ReadLine();
                    foreach (string fruit2 in fruits)
                    {

                        if (fruit2 == usersFruit2)
                        {
                            int index = fruits.IndexOf(usersFruit2);
                            Console.WriteLine(usersFruit2 + " is at index " + index);
                        }
                    }
                }
                //code to the loop that stops it from executing once a match has been found.
                break;
            }
            Console.ReadLine();

            //A list of strings that has at least two identical strings in the list
            List<string> days = new List<string>() { "Monday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            Console.WriteLine("Please enter a Day of the Week..");
            string userday = Console.ReadLine();

            foreach (string day in days)
            {
                if (userday != day)
                {
                    //check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                    Console.WriteLine("Sorry but your input is not on the list..\nTry Again(hint:capitalize weekdays)");
                    Console.WriteLine("Please enter a Day of the Week..");
                    string userday2 = Console.ReadLine();
                    foreach (string day1 in days)
                    {
                        if (userday2 == day1)
                        {
                            int index = days.IndexOf(userday2);
                            int index2 = days.LastIndexOf(userday2);
                            Console.WriteLine(userday2 + " is at index " + index + " and " + index2);
                            Console.ReadLine();
                        }
                    }
                    break;
                }
                else if ( userday == day)
                {
                    int index = days.IndexOf(userday);
                    int index2 = days.LastIndexOf(userday);
                    Console.WriteLine(userday + " is at index " + index + " and " + index2);
                    Console.ReadLine();
                }
                break;
            }
            // foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list
            foreach (string day in days)
            {
                int index = days.IndexOf(day);
                int index2 = days.LastIndexOf(day);
                if (index == index2)
                {
                    Console.WriteLine(day + " only appears once in list");
                }
                else if (index != index2)
                {
                    Console.WriteLine(day + " appears more than once");
                }
                
            }
            Console.ReadLine();

        }
    }
}
