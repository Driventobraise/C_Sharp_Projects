using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    public class Math
    {
        //method with optional parameters
        public int Divide(int x, int y = 2)
        {
            return x / y;
        }
    }
}
