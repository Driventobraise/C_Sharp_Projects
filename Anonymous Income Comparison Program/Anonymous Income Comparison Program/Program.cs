using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Person 1 salary input
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            byte hoursWorked1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("You have worked " + hoursWorked1 + " Hours " + " at " + hourlyRate1 + " dollars an hour.");
            Console.ReadLine();

            // Person 2 salary input
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            byte hoursWorked2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("You have worked " + hoursWorked2 + " Hours " + " at " + hourlyRate2 + " dollars an hour.");
            Console.ReadLine();

            // Annual salary 
            int weeksInYear = 52;
            decimal annualSalary1 = hourlyRate1 * hoursWorked1 * weeksInYear;
            decimal annualSalary2 = hourlyRate2 * hoursWorked2 * weeksInYear;
            Console.WriteLine("Annual Salary of Person 1: " + annualSalary1);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2: " + annualSalary2);
            Console.ReadLine();

            // Compare 
            bool compareSalary = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + compareSalary);
            Console.ReadLine();
        }
    }
}
