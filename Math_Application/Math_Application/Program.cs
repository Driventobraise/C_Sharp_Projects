using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiplication
            Console.WriteLine("Please input number...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 50;
            double total = num1 * num2;
            Console.WriteLine("The Product of " + num1 + " of " + num2 + " is " + total);
            Console.ReadLine();

            //Addition
            Console.WriteLine("Please input number...");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = 25;
            int total2 = num3 + num4;
            Console.WriteLine("The Sum of " + num3 + " of " + num4 + " is " + total2);
            Console.ReadLine();

            //Division
            Console.WriteLine("Please input number...");
            int num5 = Convert.ToInt32(Console.ReadLine());
            float num6 = 12.5f;
            float total3 = num5 / num6;
            Console.WriteLine("The quotient of " + num5 + " of " + num6 + " is " + total3);
            Console.ReadLine();

            //Boolean
            Console.WriteLine("Please input number...");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = 50;
            bool isGreaterThan = num7 >= num8;
            Console.WriteLine("Is " + num7 + " greater than " + num8 + " ? " + isGreaterThan);
            Console.ReadLine();

            //Remainder
            Console.WriteLine("Please input number...");
            int num9 = Convert.ToInt32(Console.ReadLine());
            int num10 = 7;
            int remainder = num9 % num10;
            Console.WriteLine("The Remainder of " + num9 + "/" + num10 + " is: " + remainder);
            Console.ReadLine();

        }
    }
}
