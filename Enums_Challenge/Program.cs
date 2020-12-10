using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Challenge
{
    class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {

            
            DayOfWeek Today = DayOfWeek.Thursday;

            Console.WriteLine("Enter the current day of the week: ");
            string userWeekDay = Console.ReadLine();

            try
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userWeekDay);
                if (day == Today)
                {
                    Console.WriteLine("Yes today is {0}.", day);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No today is not {0}.", day);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
           
            
        }
    }
}
