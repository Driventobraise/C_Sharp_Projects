using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Function
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Asking user for input
            Console.WriteLine("Please Enter An Integer: ");
            int userInteger = Convert.ToInt32(Console.ReadLine());

            // instantiating the Math object
            Math math = new Math();
            //Calling the Class Maths methods
            int x = math.Add(userInteger, 5);
            int y = math.Mult(userInteger, x);
            int z = math.Div(y, userInteger);

            Console.WriteLine(userInteger + " + " + "5" + " = " + x);
            Console.WriteLine(userInteger + " * " + x + " = " + y);
            Console.WriteLine(y + " / " + userInteger + " = " + z);
            Console.ReadLine();
        }
    }
}
