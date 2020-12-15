using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORE_EXCEPTION_HANDLINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("How old are you?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    
                }
                // Handling if the user enters 0 or below as an age.
                if (age < 1)
                {
                    throw new YouCantBeThatAge();
                }
                int timeNow = DateTime.Now.Year;
                int youWhereBorn = timeNow - age;
                Console.WriteLine("You where born in {0}", youWhereBorn);
                Console.ReadLine();

            }
            catch (YouCantBeThatAge)
            {
                Console.WriteLine("Please enter age greater than zero..");
                Console.ReadLine();
            }
            //General catch
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please contact your Systems Administrator.");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
