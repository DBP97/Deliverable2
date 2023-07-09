/*
 * Author: Deep Patel
 * Date:07/10/2023
 * Description: C# Programming: Arrays and Methods
*/
using System;

namespace Methods_Application
{
    class Program
    {
        // Creates random list of numbers from 10 to 50 from the input
        static int[] RandomArray(int arrayLength)
        {
            Random random = new Random();
            int[] myArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = random.Next(10, 50);
            }
            return myArray;
        }

        static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            bool InputValidity = false;
            int input = 0;

            while (!InputValidity)
            {
                // try-catch statement to ensure user enters right information
                try
                {
                    Console.WriteLine("Enter an integer between 5 and 15:");
                    input = int.Parse(Console.ReadLine());

                    if (input < 5 || input > 15)
                    {
                        throw new ArgumentException("Please enter an integer between 5 and 15.");
                    }

                    InputValidity = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int[] sampleArray = RandomArray(input);

            // Output for list of numbers
            Console.WriteLine("The elements of the array are:");
            foreach (int num in sampleArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Output for sum of random numbers
            int sum = Sum(sampleArray);
            Console.WriteLine("The sum is: " + sum);
        }
    }
}