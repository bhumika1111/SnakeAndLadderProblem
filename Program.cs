using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("************Output For Single Player Starts with Position 0 *********** ");
              SnakeLadderPosition.CheckPlayerPosition();
              Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
              Console.WriteLine("************Output For,Player Roll The Die To Get The Random Number Between 1 To 6:");
              RollDice.CheckPlayerRollsDie();
              Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
              Console.WriteLine("************Output For  They Are No-Play,Getting Ladder Or Bit Snake.**************** ");
             CheckOption.CheckForOption();
             Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*********Output For The Conditions Are Repeat Till The  Player Reaches Position 100.************");
             WinningPosition.CheckWinningPosition();
             Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*********Output For The Player Gets Exact Winning Position************");
             ExactWinningPosition.CheckExactWinningPosition();
             Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*********Output For The Number Of Times The Dice Was Played To Win Game************");
             CheckDice.CheckDiceForWin();
            

        }
    }
}
