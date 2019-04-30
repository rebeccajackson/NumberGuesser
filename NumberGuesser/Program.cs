using System;

namespace NumberGuesser
{
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
           
            while (true) {

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Yikes, that wasn't a number!");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Sorry that's not quite right, guess again");
                    }
                }

                PrintColorMessage(ConsoleColor.DarkYellow, "That's right, finally!");

                Console.WriteLine("Do you want to keep playing? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;

                } else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Display app info
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rebecca Jackson";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

        }

        static void GreetUser()
        {
            // Get and display user name
            Console.WriteLine("What's your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
