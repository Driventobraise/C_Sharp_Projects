using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORE_EXCEPTION_HANDLINGS
{
    public class YouCantBeThatAge : Exception
    {
        
        public YouCantBeThatAge()
            : base() { }
        public YouCantBeThatAge(string message)
            : base(message) { }
        
    }
}
