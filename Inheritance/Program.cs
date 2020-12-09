using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Calling the superclass method
            employee.SayName();
        }
    }
}
