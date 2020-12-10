using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type "string"
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Is", "doing", "a", "good", "Job." };
            // the only reason I created another variable was because
            // list1 is easier to reuse than employee.Things
            List<string> list1 = employee1.Things;

            //looping with for loop
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            Console.ReadLine();

            //Instantiate an Employee object with type "int"
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3, 4 };
            List<int> list2 = employee2.Things;

            //lloping with foreach loop
            foreach (int thing in list2)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();


        }
    }
}
