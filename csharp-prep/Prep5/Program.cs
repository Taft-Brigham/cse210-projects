using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string UserName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(UserName, squaredNumber);
        }


            
            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the program!");
            }

            static string PromptUserName()
            {
                Console.Write("Please enter your name: ");
                string UserName = Console.ReadLine();
                return UserName;
            }

            static int PromptUserNumber()
            {
                Console.Write("Please enter your favorite number: ");
                string UserResponse = Console.ReadLine();
                int UserNumber = int.Parse(UserResponse);
                return UserNumber;
            }

            static int SquareNumber (int number)
            {
                int Square =  number * number;
                return Square;
            }

            static void DisplayResult(string UserName, int Square)
            {
                Console.WriteLine($"{UserName}, the square of your number is {Square}");
            }
    }
}