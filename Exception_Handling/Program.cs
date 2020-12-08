using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 9, 99, 15, 12, 7, 35 };

            
            try
            {
                Console.WriteLine("Please enter a number to divide elements by..");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int dividend = number / userNumber;
                    Console.WriteLine(number + " divide by " + userNumber + " equals " + dividend);
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter whole numbers only.");
                return;
            }           
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Try and Catch Complete.");
                Console.ReadLine();
            }

        }
    }
}
