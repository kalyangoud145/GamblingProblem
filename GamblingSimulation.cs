using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingProblem
{
    class GamblingSimulation
    {
        /// <summary>
        /// Declaring the stake for playing the game
        /// and every game bet
        /// </summary>
        public const  int STAKE = 100;
        public const  int BET = 1;
        /// <summary>
        /// Prints whether the player Win  or loose the bet
        /// </summary>
        public void WinOrLoose()
        {
            Random random = new Random();
            int randomCheck = random.Next(2);
            if(randomCheck == 0)
            {
                Console.WriteLine("Player Won the bet");
            }
            else
            {
                Console.WriteLine("Player lost the bet");
            }
        }

    }
}
