using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    /// <summary>
    /// Here We Check The Player Checks The Option, They Are No-Play,Getting Ladder Or Bit Snake.
    /// </summary>
    public class CheckOption
    {
        public const int ladder = 1;
        public const int snake = 2;
        /// <summary>
        /// Checks for option.
        /// </summary>
        public static void CheckForOption()
        {
            
            int position = 0;
            Console.WriteLine("Player Start From Position: " + position);

            Random random = new Random();
            int dieRoll= random.Next(1, 7);
            position = dieRoll;
            Console.WriteLine("The output For Getting dice number: " + position);


            int options = random.Next(0, 3);
            Console.WriteLine(" The Output For Getting Options: " + options);

            switch (options)
            {
                case ladder:
                    Console.WriteLine("****** Wow! Getting Ladder********");
                    position = position + dieRoll;
                    Console.WriteLine("Position:" +position);
                    break;

                case snake:
                    Console.WriteLine("$$$$$Oops!Snake bit$$$$$$$$$");
                    position = position - dieRoll;
                    Console.WriteLine("Position:" + position);
                    if (position < 0)
                    {
                        position = 0;
                        Console.WriteLine("Player Restart From Position 0:" + position);
                        
                    }

                    break;

                    default:
                    Console.WriteLine("=======No-Play========");
                    break;
            }
            
        }
    }
}
