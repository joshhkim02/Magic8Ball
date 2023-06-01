using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    internal class Menu
    {
        internal void showMenu()
        {
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("This is your Magic 8 Ball.\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to ask a question.");
                Console.WriteLine("Enter 2 to view your previous questions.");
                Console.WriteLine("Enter 3 to exit the application.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        _8BallEngine.AskQuestion();
                        break;
                    case "2":
                        Helpers.ViewPreviousQ();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye! See you next time.");
                        closeApp = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid command. Please choose a number from 1 to 3.");
                        break;
                }
            }
        }
    }
}
