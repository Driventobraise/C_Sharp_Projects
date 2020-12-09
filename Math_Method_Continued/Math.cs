using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Method_Continued
{
    public class Math
    {
        public int Mult(int x)
        {
            return x * 5;
        }

        public int Mult(decimal x)
        {
            return Convert.ToInt32(x * 2.5m);
        }

        public int Mult(string x)
        {
            int z = Convert.ToInt32(x);
            return z * 10;
        }
    }
}
