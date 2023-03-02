using System;

namespace SwitchStatementsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Party Age Calculator!\nPlease enter your age: ");
            string userInput = Console.ReadLine();
            int userAge; 
            bool ageIsNumerical = Int32.TryParse(userInput, out userAge);

            if (userAge >= 18 && ageIsNumerical == true)
            {
                Console.WriteLine("You're good to go! Have fun!");
                Console.Read();
            }
            else if (userAge <= 17 && ageIsNumerical == true)
            {
                Console.WriteLine("Too bad! You're too young to enter a club");
                Console.Read();
            }
            else 
            {
                ageIsNumerical= false;
                Console.WriteLine("Invalid input. Please restart the program.");
                Console.Read();
            }
        }
    }
}
