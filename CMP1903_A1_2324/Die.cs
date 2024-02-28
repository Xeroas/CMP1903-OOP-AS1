using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int _dieCurVal;
        private static Random _randNum = new Random();

        public int Roll() //Method
        {
            _dieCurVal = _randNum.Next(1, 7); //Generates number from 1 to 6 (7 Is not included)
            return _dieCurVal;
        }
    }
}
