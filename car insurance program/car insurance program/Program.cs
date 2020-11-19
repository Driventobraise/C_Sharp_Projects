using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_insurance_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // age input
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // DUI input
            Console.WriteLine("Have you ever had a DUI? Please respond \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // speeding ticket input
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Boolean logic to see is you qualify
            bool qualified = age >= 15 && dui == false && speedingTickets <= 3;
            Console.WriteLine( "Are you Qualified? " + qualified);
            Console.ReadLine();

        }
    }
}
