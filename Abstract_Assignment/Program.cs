using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            //using polymorphism to create an object of type IQuittable
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
