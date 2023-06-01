using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    internal class _8BallEngine
    {
        internal static void AskQuestion()
        {
            Console.Clear();
            Console.WriteLine("What is your question?");

            string userQuestion = Console.ReadLine();

            userQuestion = Helpers.ValidateInput(userQuestion);

            ProvideAnswer();
            Helpers.AddToHistory(userQuestion);

            Console.WriteLine("Enter any key to go back to the menu, or enter 0 to exit the application.");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "0")
            {
                Console.WriteLine("Goodbye! See you next time.");
                Environment.Exit(0);
            }
        }

        internal static void ProvideAnswer()
        {
            Random rand = new();
            int pickAnswer = rand.Next(1, 21);

            switch (pickAnswer)
            {
                case 1:
                    Console.WriteLine("It is certain.");
                    break;
                case 2:
                    Console.WriteLine("It is decidedly so.");
                    break;
                case 3:
                    Console.WriteLine("Without a doubt.");
                    break;
                case 4:
                    Console.WriteLine("Yes definitely.");
                    break;
                case 5:
                    Console.WriteLine("You may rely on it.");
                    break;
                case 6:
                    Console.WriteLine("As I see it, yes.");
                    break;
                case 7:
                    Console.WriteLine("Most likely.");
                    break;
                case 8:
                    Console.WriteLine("Outlook good.");
                    break;
                case 9:
                    Console.WriteLine("Yes.");
                    break;
                case 10:
                    Console.WriteLine("Signs point to yes.");
                    break;
                case 11:
                    Console.WriteLine("Reply hazy, try again.");
                    break;
                case 12:
                    Console.WriteLine("Ask again later.");
                    break;
                case 13:
                    Console.WriteLine("Better not tell you now.");
                    break;
                case 14:
                    Console.WriteLine("Cannot predict now.");
                    break;
                case 15:
                    Console.WriteLine("Concentrate and ask again.");
                    break;
                case 16:
                    Console.WriteLine("Don't count on it.");
                    break;
                case 17:
                    Console.WriteLine("My reply is no.");
                    break;
                case 18:
                    Console.WriteLine("My sources say no.");
                    break;
                case 19:
                    Console.WriteLine("Outlook not so good.");
                    break;
                case 20:
                    Console.WriteLine("Very doubtful.");
                    break;
            }
        }
    }
}
