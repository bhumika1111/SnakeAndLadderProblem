using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    /// <summary>
    /// Here We Check The Player Roll Die By Using Random Generator.
    /// </summary>
    public class RollDice
    {
        /// <summary>
        /// Checks the player rolls die.
        /// </summary>
        public static void CheckPlayerRollsDie()
        {
            int position = 0;
            Console.WriteLine("Player Starts From Position 0:", position);
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            position = dieRoll;
            Console.WriteLine("position:" + position);


            

        }
    }
}
