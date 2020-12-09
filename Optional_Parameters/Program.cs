using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Math math = new Math();

            //User Input
            Console.WriteLine("Enter a number: ");
            int userInt1 = Convert.ToInt32(Console.ReadLine());

            //handling optional user input
            Console.WriteLine("(OPTIONAL)Enter a second number: ");
            int userInt2;
            int result;
            if (int.TryParse(Console.ReadLine(), out userInt2))
            {
                result = math.Divide(userInt1, userInt2);
            }
            else
            {
                result = math.Divide(userInt1);
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
