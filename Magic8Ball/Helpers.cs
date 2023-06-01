using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    internal class Helpers
    {

        static List<string> previousQuestions = new();

        internal static void ViewPreviousQ()
        {
            Console.Clear();
            Console.WriteLine("Previous questions:");
            Console.WriteLine("-----------------------------------");
            foreach (string question in previousQuestions)
            {
                Console.WriteLine(question);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter any key to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

        internal static void AddToHistory(string question)
        {
            previousQuestions.Add(question);
        }

        internal static string ValidateInput(string question)
        {
            while (string.IsNullOrEmpty(question) || Int32.TryParse(question, out int value))
            {
                Console.WriteLine("Your question was either null, empty, or not a string. Try again.");
                question = Console.ReadLine();
            }
            return question;
        }
    }
}
