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

            for (; ; ) //Create a loop which will generate games until told to stop
            {
                var gameStart1 = Game1.StartGame(); //Run the "Game" method (Roll three die)
                Console.WriteLine($"-------------------\nSum is = {gameStart1.Item1}\n-------------------"); ///Output the sum of the three dies (With some ASCII formatting).
                Console.WriteLine("Enter 'Stop' to stop rolling, enter anything else to continue rolling.");
                var userInput = Console.ReadLine(); //Take user input to check if they would like to stop rolling or continue.
                var userInputLower = userInput.ToLower();  //Convert user input to lowercase to prevent erroneous input.

                if (userInputLower == "stop") //If condition which will stop the program if user inputs 'Stop'
                {
                    break;
                }
            }
        }
    }
}
