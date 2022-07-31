using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    /// <summary>
    /// Here We Check Number Of Times The Dice Was Played To Win The Game And Position After Every Dice Roll.
    /// </summary>
    public class CheckDice
    {
        public const int ladder = 1;
        public const int snake = 2;
        /// <summary>
        /// Checks the dice for win.
        /// </summary>
        public static void CheckDiceForWin()
        {
            int position = 0;
            int dieRoll;
            Console.WriteLine("Player Start At Position" + position);
            Random random = new Random();

            while (position < 100)
            {

                dieRoll = random.Next(1, 7);
                int options = random.Next(0, 3);

                switch (options)
                {
                    case ladder:
                        Console.WriteLine("**Wow!GettingLadder**");
                        position = position + dieRoll;
                        if (position == 94 || dieRoll == 6 || position == 96 || dieRoll == 4 || position == 98 || dieRoll == 2 ||
                                     position == 95 || dieRoll == 5 || position == 97 || dieRoll == 3 || position == 99 || dieRoll == 1)
                        {

                            Console.WriteLine("dieRoll:" + dieRoll);


                        }

                        if (position > 100)
                        {
                            position = position - dieRoll;
                        }

                        break;
                    case snake:
                        Console.WriteLine("$$Oops!snake bit$$");
                        position = position - dieRoll;
                        Console.WriteLine("dieRoll:" + dieRoll);
                        Console.WriteLine("Position:" + position);

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

                Console.WriteLine("**Present Position Is:**" + position);

            }
          
            
            Console.WriteLine("*******Congratulations! Player Wins******");
            Console.WriteLine("#### START THE GAME AGAIN ####");

        }


    }
}