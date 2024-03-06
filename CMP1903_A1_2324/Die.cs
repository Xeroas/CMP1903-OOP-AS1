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

        /// <summary>
        /// The "Die" class is responsible for defining the Die and assigning it a random value within the range 1-6. 
        /// this is done with the help of the "Roll" method which generates the die values within the expected range.
        /// </summary>


        //Property
        private int _dieCurVal; //Private variable created to hold the current value of the die privately (Encapsulated).

        public int pubCurVal
        {
            get => _dieCurVal; //Encapsulation of "_dieCurVal"
            set { _dieCurVal = value; }
        }
        private static Random _randNum = new Random(); //Private "random" variable created, set to static to stop overlapping die values.

        public int Roll() //"Roll" Method responsible for rolling the die and returning a value within the expected range (1-6)
        {
            pubCurVal = _randNum.Next(1, 7); //Generates number from 1 to 6 (7 Is not included)
            return pubCurVal; //Returns the randomly (Within range of 1-6) generated die value
        }
    }
}
