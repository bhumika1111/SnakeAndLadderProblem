using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class ExactWinningPosition
    {
        public const int ladder = 1;
        public const int snake = 2;
        public static void CheckExactWinningPosition()
        {
            int position = 0;
            int dieRoll;
            Console.WriteLine("Player start At Position" + position);
            Random random = new Random();

            while (position < 100 )
            {

                dieRoll = random.Next(1, 7);
                int options = random.Next(0, 3);

                switch (options)
                {
                    case ladder:
                        Console.WriteLine("**Wow!GettingLadder**");
                        position = position + dieRoll;
                        Console.WriteLine("Position:" + position);
                        break;
                    case snake:
                        Console.WriteLine("$$Oops!snake bit$$");
                        position = position - dieRoll;
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
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::");
                       if (position>100)
                        {
                            position = position - dieRoll;
                            Console.WriteLine("Previous Position:" );
                            Console.WriteLine(position);
                        }

            }
            Console.WriteLine("*******Congratulations! Player Wins******");
            Console.WriteLine("#### START THE GAME AGAIN ####");

        }
    }
}      


