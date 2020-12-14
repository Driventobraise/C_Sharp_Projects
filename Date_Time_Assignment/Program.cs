using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the current date and time to the console.
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            //I originally had userHour set as  DateTime, but once i got to the .AddHours method I found out it was looking for a Double so I changed the format of the user input. 
            double userHour = Convert.ToDouble(Console.ReadLine());
            DateTime timeNow = DateTime.Now;
            DateTime xHoursLater = timeNow.AddHours(userHour);

            Console.WriteLine("In {0} hours it will be {1}.", userHour, xHoursLater);
            Console.ReadLine();

            
        }
    }
}
