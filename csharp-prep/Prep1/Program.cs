using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is prep 1");
            Console.WriteLine("Welcome to the new world of C#");
            Console.WriteLine("");

            // Prompt the user for their first name
            Console.Write("What is your first name? ");
            string firstname = Console.ReadLine();

            // Prompt the user for their last name
            Console.Write("What is your last name? ");
            string lastname = Console.ReadLine();

            Console.WriteLine("");

            // Display the text back
            Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
            
        }
    }
}