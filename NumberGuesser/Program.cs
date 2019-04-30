﻿using System;

namespace NumberGuesser
{
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rebecca Jackson";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What's your name?");

            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play...", inputName);

            int correctNumber = 8;
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                string input = Console.ReadLine();
                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sorry that's not quite right, guess again");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("That's right, finally!");
            Console.ResetColor();

        }
    }
}
