using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    /// <summary>
    /// Here We Check The Conditions Are Repeat Till The  Player Reaches Position 100.
    /// </summary>
    public class WinningPosition
    {
        public const int ladder = 1;
        public const int snake = 2;

        /// <summary>
        /// Checks the winning position.
        /// </summary>
        public static void CheckWinningPosition()
        {
            int position = 0;

            Console.WriteLine("Player start At Position" + position);
            Random random = new Random();

            while (position < 100 && position <= 100)
            {
                int dieRoll = random.Next(1, 7);
                int options = random.Next(0, 3);

                switch (options)
                {
                    case ladder:
                        Console.WriteLine("**Wow!GettingLadder**");

                        position = position + dieRoll;

                        if (position > 100)
                        {
                            position = 0;
                        }
                        break;
                    case snake:
                        Console.WriteLine("$$Oops!snake bit$$");

                        position = position - dieRoll;
                        if (position < 0)
                        {
                            position = 0;
                            Console.WriteLine("Player Restart From Position 0:");
                        }
                        break;

                    default:
                        Console.WriteLine("===No-Play===");
                        break;
                }
                Console.WriteLine("**Present position is:**" + position);
            }

            Console.WriteLine("*******Congratulations! Player Wins******");
            Console.WriteLine("#### START THE GAME AGAIN ####");
        }        
    }
}


