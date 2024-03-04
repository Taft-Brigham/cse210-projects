using System;
using System.Reflection.Metadata;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");

            
            // Ask the user for their grade
            Console.Write("Please enter your grade? ");
            string userInput = Console.ReadLine();
            int userGrade = int.Parse(userInput);

            //Handling stretch challenges
            string letter;
            string sign = "";
            

            if (userGrade >= 90)
            {
                letter = "A";
            }

            else if (userGrade >= 80)
            {
                letter = "B";
            }

             else if (userGrade >= 70)
            {
                letter = "C";
            }

             else if (userGrade >= 60)
            {
                letter = "D";
            }

             else 
            {
                letter = "F";
            }
            int lastDigit = userGrade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }

            else if (lastDigit < 3 && userGrade != 100)
            {
                sign = "-";
            }

            if (letter == "A" && sign == "+")
            {
                letter = "A";
                sign = "";
            }
            else if (letter == "F" && (sign == "+" || sign == "-"))
            {
                sign = "";
            }

             Console.WriteLine($"You had Grade {letter}{sign}");

            // Check user have at least a 70 to pass the class.
            if (userGrade >= 70)
            {
                Console.WriteLine("Congratulations you passed this Course :)");
            }
            else
            {
                Console.WriteLine("You almost passed. Learn harder next time :(");
            }

        }
    }
}