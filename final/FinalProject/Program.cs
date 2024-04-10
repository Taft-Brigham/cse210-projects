using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("Task Management System");
            Console.WriteLine("1. Display Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task as Complete");
            Console.WriteLine("4. Save Tasks");
            Console.WriteLine("5. Load Tasks");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Tasks:");
                    taskManager.DisplayTasks();
                    break;
                case 2:
                    taskManager.AddTask();
                    break;
                case 3:
                    taskManager.MarkTaskAsComplete();
                    break;
                case 4:
                    taskManager.SaveTasks();
                    break;
                case 5:
                    taskManager.LoadTasks();
                    break;
                case 6:
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
