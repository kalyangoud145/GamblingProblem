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
        public const int STAKE = 100;
        public const int BET = 1;
        /// <summary>
        /// Prints whether the player Win  or loose the bet
        /// </summary>
        public bool WinOrLoose()
        {
            Random random = new Random();
            int randomCheck = random.Next(2);
            if (randomCheck == 0)
            {
                Console.WriteLine("Player Won the bet");
                return true;
            }
            else
            {
                Console.WriteLine("Player lost the bet");
                return false;
            }
        }
        /// <summary>
        /// retrive the per day game range
        /// </summary>
        public int RetrivePerDayGameRange()
        {
            int money = STAKE;
            while (money > STAKE / 2 && money < STAKE + STAKE / 2)
            {
                if (WinOrLoose())
                {
                    money += BET;
                }
                else
                {
                    money -= BET;
                }

            }
            Console.WriteLine("Todays remaining amount is: " + money);
            return money;
        }
        /// <summary>
        /// Amount for win or loose for twenty days.
        /// </summary>
        public void AmountWinOrLooseForTwentyDays()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(RetrivePerDayGameRange());
            }
            // Prints the amount  day wise
            foreach (int dayAmount in list)
            {
                Console.WriteLine(dayAmount);
            }
        }
    }
}
