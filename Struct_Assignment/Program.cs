using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        };

        static void Main(string[] args)
        {
            Number number;
            number.Amount = 2.5m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
