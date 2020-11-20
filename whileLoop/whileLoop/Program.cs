using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            Console.WriteLine("What Year was the First Computer built?");
            int compYear = Convert.ToInt32(Console.ReadLine());

            bool guess = compYear == 1943;
            while (!guess) 
            {
                switch (compYear)
                {
                    case 1943:
                        Console.WriteLine("You guessed " + compYear + ". That is correct");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + compYear + ". That is incorrect");
                        Console.WriteLine("What Year was the First Computer built?");
                        compYear = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
            
            // There is a small issue switching between Programs, The do while loop while fire off once before it accepts user input, not sure how to correct this but its not fatal.
            
            // Setting up the input for do while loop
            Console.WriteLine("What is the best Pet?");
            string pet = Console.ReadLine();
            // atempting to normalize data by making all inputs lower case.
            string lowerPet = pet.ToLower();

            // Boolean logic stating that cat is == true.
            bool bestPet = lowerPet == "cat";

            // do while loop.
            do
            {
                switch (lowerPet)
                {
                    // Correct answer case
                    case "cat":
                        Console.WriteLine("Yup " + lowerPet + "'s" + " are the best pets.");
                        bestPet = true;
                        break;
                    // A catch for any other pet
                    default:
                        Console.WriteLine("I am sorry but a " + lowerPet + " is not the best pet");
                        Console.WriteLine("What is the best Pet?");
                        pet = Console.ReadLine();
                        lowerPet = pet.ToLower();
                        break;
                }
            }
            while (!bestPet);
            Console.Read();


        }
    }
}
