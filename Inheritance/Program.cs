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
            employee.ID = 1;

            Employee employee2 = new Employee();
            employee2.FirstName = "Sample2";
            employee2.LastName = "Student2";
            employee2.ID = 2;

            //Compairing empoyee ids
            Console.WriteLine(employee == employee2);
            Console.ReadLine();
            // Calling the superclass method
            //employee.SayName();
        }
    }
}
