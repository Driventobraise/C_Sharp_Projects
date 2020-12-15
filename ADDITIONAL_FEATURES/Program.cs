using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDITIONAL_FEATURES
{
    public class Program
    {
        static void Main(string[] args)
        {
            //const variable.
            const string schoolName = "The Tech Acadamy";

            //Creating a variable using the keyword "var.”
            var employeeList = new List<Tuple<string, string, int>>();
            employeeList.Add(Tuple.Create("Joe", "Bob", 1));
            foreach (var employee in employeeList)
            {
                string s = employee.Item1;
                string s2 = employee.Item2;
                int i = employee.Item3;
                //displaying constant variable and "var" utilization.
                Console.WriteLine("{0} {1} goes to {2}.", s, s2, schoolName);
                Console.ReadLine();
            }
            //Chaining two constructors together.
            ChainConstructors person = new ChainConstructors("Jesse");

            Console.WriteLine(Convert.ToString(person.Age));
            Console.WriteLine(person.Name);
            Console.ReadLine();

            
        }
    }
}
