using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            /// <summary>
            /// The "Program" class contains the code to be ran by the program, in this case it includes the "Testing" method and "Game" method which are both instantiated and executed,
            /// the Testing is done first and then the game will run in a loop until the user tells it to stop.
            /// </summary>


            Game Game1 = new Game(); //Object instantiation, loading "Game" into the program class.

            Testing Test1 = new Testing(); //Object instantiation, loading "Testing" into the program class.
            Test1.Test(); //Run the testing method
            Console.WriteLine("-------------------\nTesting complete\n-------------------"); //So long as no errors occur, this line will be output to let the user know testing has completed.


            string userInput;
            do
            {
                Console.WriteLine("If you would like to stop rolling please enter 'Stop'\nPlease enter how many times would you like to roll the dies :");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "stop") //If user enters "stop", stop the loop
                {
                    break;
                }

                try
                {
                    int timesToRoll = Int32.Parse(userInput); //Cast userInput to int
                    for (int rollCounter = 1; rollCounter <= timesToRoll; rollCounter++) //Create counter to Roll dies based on user input
                    {
                        var gameStart1 = Game1.StartGame(); //Run the "Game" method (Roll three die)
                        Console.WriteLine($"-------------------\nSum is = {gameStart1.Item1}\n-------------------"); ///Output the sum of the three dies (With some ASCII formatting).
                    }
                }
                catch (FormatException) //If user inputs string this will catch it and display appropriate message
                {
                    Console.WriteLine("\nIncorrect input, please enter a number!\n");
                }

                catch (Exception) //If user error-causing input this will catch it and display appropriate message
                {
                    Console.WriteLine("Unexpected error, please try again!");
                }
            } while (true); //Ensure code above loops while true (user has not told the code to stop)
        }
    }
}
