using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numberSeries = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        float average = 0;
        int largestNumber = 0;


        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            //checking that 0 is not added to the list
            if (userNumber != 0)
            {
                numberSeries.Add(userNumber);
            }


            if (userInput == "0")
            {
                //looping through all the numbers in the number series
                foreach (int number in numberSeries)
                {
                    int count = numberSeries.Count;
                    sum += number;
                    average = (float)sum / count;
                    if (number > largestNumber)
                    {
                        largestNumber = number;
                    }

                }
               

                //Displaying the resulting values
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The Largest Number is: {largestNumber}");


                 //checking for the smallest positive number
                int smallestPositive = int.MaxValue;
                foreach(int num in numberSeries)
                {
                    if (num > 0 && num < smallestPositive)
                    {
                        smallestPositive = num;
                    }
                }

                if(smallestPositive != int.MaxValue)
                {
                    Console.WriteLine($"The smallest positive number is: {smallestPositive}");
                }

                // sorting the numbers
                numberSeries.Sort();

                // displaying the sorted numbers
                Console.WriteLine("The sorted list is:");
                foreach (int num in numberSeries)
                {
                    Console.WriteLine(num);
                }
                
                break;
            }
        }
    }
}