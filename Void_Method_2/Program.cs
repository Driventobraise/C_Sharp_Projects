using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate that class
            Math math = new Math();

            Console.WriteLine("Please enter a Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //calling method on user input
            math.MyMethod(x);

            
            int y;
            //Calling method with output parameter
            math.getNumber(out y);

            // Calling overload method
            int num1 = math.addMethod(12, 14);
            double num2 = math.addMethod(2.23, 4.45);
            Console.WriteLine("int: {0}, Double: {1}", num1, num2);
            Console.ReadLine();

            //Accessing Static Member
            int result = Calculator.Sum(25, 47);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
