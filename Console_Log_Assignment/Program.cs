using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_Log_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            //I am not converting the user input to int beacuse we are only interested in oporating apon it in string format.
            //I could have converted here but it would have added unnecessary code imo.
            string userNum = Console.ReadLine();
            // Loging user number to a text file.
            File.WriteAllText(@"C:\Users\jesse\Logs\log2.text", userNum);
            //reading text file and casting it to a string variable to read it.
            string text = File.ReadAllText(@"C:\Users\jesse\Logs\log2.text");

            Console.WriteLine(text);
            Console.ReadLine();
            
            
        }
    }
}
