using System;
using System.Net;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");
            //Kept this code to remember I asked the user 
            // before changing to random
            // Console.Write("What is the magic number? ");
            // string userInput = Console.ReadLine();
            // int magicNumber = int.Parse(userInput);


            string gameName = "Number Guessing Game";

            // generate a random number from 1 to 100.
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int magicNumber = number;

            int gameCount = 0;
            string response = "yes";


            while (response == "yes")
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                int guessNumber = int.Parse(userGuess);

                // Keeping track of how many guesses
                gameCount++;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber == magicNumber)
                {
                    Console.WriteLine("Congratulations you guessed it right!!");
                    Console.WriteLine($"You guessed {gameCount} times");

                    Console.WriteLine("");

                    // asking  the user if they want to play agian
                    // to continue the loop
                    Console.Write("Do you want to play again? (Enter Yes/No) ");
                    string userResponse = Console.ReadLine().ToLower();
                    if (userResponse != "yes")
                    {
                         Console.WriteLine($"Thanking for playing {gameName}");
                        break;
                    } 
                }  
            }
        }
    }
}
