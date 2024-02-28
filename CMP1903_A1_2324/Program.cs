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

            Game Game1 = new Game(); //object instantiation
            int gameStart1 = Game1.StartGame();

            Console.WriteLine($"Sum is = {gameStart1}");
            Console.ReadLine(); //Can be deleted, placeholder to keep console open
        }
    }
}
