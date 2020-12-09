using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_2
{
    public class Math
    {
        //void method that outputs an integer
        public void MyMethod( int x)
        {
            int y = x / 2;
            Console.WriteLine(y);
            Console.ReadLine();
        }

        //method with output parameters.
        public void getNumber(out int x)
        {
            Console.WriteLine("Enter another Number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.ReadLine();
        }

        //overload method
        public int addMethod( int x, int y)
        {
            return x + y;
        }
        public double addMethod( double x, double y)
        {
            return x + y;
        }
    }
}
