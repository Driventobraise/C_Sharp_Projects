using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base employee list
            var employeeList = new List<Tuple<string, string, int>>();
            employeeList.Add(Tuple.Create("Joe", "Bob", 1));
            employeeList.Add(Tuple.Create("Joe", "Smith", 2));
            employeeList.Add(Tuple.Create("Frank", "Ocean", 3));
            employeeList.Add(Tuple.Create("Emily", "Mast", 4));
            employeeList.Add(Tuple.Create("Kate", "Grube", 5));
            employeeList.Add(Tuple.Create("Steve", "Yabo", 6));
            employeeList.Add(Tuple.Create("French", "Stewart", 7));
            employeeList.Add(Tuple.Create("Bob", "Bobberson", 8));
            employeeList.Add(Tuple.Create("Jeff", "Jefferies", 9));
            employeeList.Add(Tuple.Create("Lo", "Pan", 10));

            //New list to deposit "Joe" employees
            var employeeList2 = new List<Tuple<string, string, int>>();

            //foreach loop, create a new list of all employees with the first name "Joe"
            foreach (var employee in employeeList)
            {
                string s = employee.Item1;
                string s2 = employee.Item2;
                int i = employee.Item3;
                if (s == "Joe")
                {
                    employeeList2.Add(employee);
                }
            }

            //foreach loop to print  employees in new list
            foreach (var employee in employeeList2)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

            //-----------------------------------------------------------------------

            //lambda expression, a new list of all employees with the first name "Joe"
            var newEmployeeList = employeeList.Where(x => x.Item1 == "Joe").ToList();

            foreach (var employee in newEmployeeList)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

            //lambda expression, a new list of all employees with Id number greater than 5."
            var newEmployeeList2 = employeeList.Where(x => x.Item3 > 5).ToList();
            foreach (var employee in newEmployeeList2)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
