using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDITIONAL_FEATURES
{
    public class ChainConstructors
    {
        public int Age { get; set; }
        public string Name { get; set; }
        //Chaining two constructors together.
        public ChainConstructors(string name) : this(name, 10) { }
        public ChainConstructors(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
