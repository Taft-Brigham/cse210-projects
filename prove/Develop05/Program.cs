using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.DisplayPlayerInfo();
                    break;
                case 2:
                    manager.ListGoalNames();
                    break;
                case 3:
                    manager.ListGoalDetails();
                    break;
                case 4:
                    manager.CreateGoal();
                    break;
                case 5:
                    Console.Write("Enter the name of the goal: ");
                    string goalName = Console.ReadLine();
                    manager.RecordEvent(goalName);
                    break;
                case 6:
                    manager.SaveGoals();
                    break;
                case 7:
                    manager.LoadGoals();
                    break;
                case 8:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
