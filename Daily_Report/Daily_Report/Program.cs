using System;

class Program
{
    static void Main(string[] args)
    {   
        // Intro
        Console.WriteLine("The Tech Academy \nStudent Daily Report");
        Console.ReadLine();

        // Name section
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("You have entered: " + yourName);
        Console.ReadLine();

        // Course section
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();
        Console.WriteLine("You have entered: " + courseName);
        Console.ReadLine();

        // Page Number section
        Console.WriteLine("What page number (page number only please)?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);
        Console.WriteLine("You have entered: " + pageNum);
        Console.ReadLine();

        // Help section
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\". ");
        string needHelp = Console.ReadLine();
        bool help = Convert.ToBoolean(needHelp);
        Console.WriteLine("You have entered: " + help);
        Console.ReadLine();

        // Experiences section
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string posExperience = Console.ReadLine();
        Console.WriteLine("You have entered: " + posExperience);
        Console.ReadLine();

        // Feedback section
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedBack = Console.ReadLine();
        Console.WriteLine("You have entered: " + feedBack);
        Console.ReadLine();

        // Hours Studied section
        Console.WriteLine("How many hours did you study today?");
        string hoursStudy = Console.ReadLine();
        float Hours = float.Parse(hoursStudy);
        Console.WriteLine("You have entered: " + Hours);
        Console.ReadLine();

        // Outro section
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}

