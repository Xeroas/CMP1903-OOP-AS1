using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        public void test() //Method
        {
            Game TestGame = new Game();

            for (int i = 0; i < 100; i++)
            {
                var TestGameResult = TestGame.StartGame();

                Debug.Assert(TestGameResult.Item1 >= 3 && TestGameResult.Item1 <= 18, "Sum Value out of range");
                Debug.Assert(TestGameResult.Item2 >= 1 && TestGameResult.Item2 <= 6, "Die Value out of range");
                Debug.Assert(TestGameResult.Item3 >= 1 && TestGameResult.Item3 <= 6, "Die Value out of range");
                Debug.Assert(TestGameResult.Item4 >= 1 && TestGameResult.Item4 <= 6, "Die Value out of range");

            }
        }
    }
}
