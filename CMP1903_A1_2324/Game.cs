using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

        Die D1 = new Die();
        Die D2 = new Die();
        Die D3 = new Die();

        //Console.WriteLine($"Die 1 = {R1} Die 2 = {R2} Die 3 = {R3}");

        public int StartGame()
        {
            int R1 = D1.Roll();
            int R2 = D2.Roll();
            int R3 = D3.Roll();

            int sum =  R1+ R2+ R3;
            Console.WriteLine($"Sum is = {sum}");
            Console.WriteLine($"Die 1 = {R1} Die 2 = {R2} Die 3 = {R3}");

            return sum;
        }
    }
}
