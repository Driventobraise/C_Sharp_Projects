using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express!");
            Console.ReadLine();

            // Package weight
            Console.WriteLine("Please enter Package weight, it will be assumed the wieght is in Lbs.");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            // Package width
            Console.WriteLine("Please enter Package width, it will be assumed the width is in inches.");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            // Package height
            Console.WriteLine("Please enter Package height, it will be assumed the height is in inches.");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            // Package length
            Console.WriteLine("Please enter Package length, it will be assumed the height is in inches.");
            int packLength = Convert.ToInt32(Console.ReadLine());

            // Calculating dimensions
            int dimensions = packHeight + packLength + packWidth;
            if (dimensions >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
            }
            else if (dimensions < 50)
            {
                int quote1 = packHeight * packWidth * packLength;
                int quote2 = quote1 * packWeight;
                decimal quote3 = quote2 / 100m;
                Console.WriteLine("Your estimated total for shipping this package is: " + "$"+ quote3);
                Console.ReadLine();
            }

            Console.WriteLine("Thank you!");
            Console.ReadLine();
            

        }
    }
}
