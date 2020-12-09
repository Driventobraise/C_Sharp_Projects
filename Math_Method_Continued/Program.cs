using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Method_Continued
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            Math math = new Math();
            int a = math.Mult(x);

            Console.WriteLine(a);
            Console.ReadLine();

            decimal y = 1.2m;
            int b = math.Mult(y);

            Console.WriteLine(b);
            Console.ReadLine();

            string z = "5";
            int c = math.Mult(z);

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
