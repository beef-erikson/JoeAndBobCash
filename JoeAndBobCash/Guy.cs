using System;
using System.Collections.Generic;
using System.Text;

namespace JoeAndBobCash
{
    class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Writes amount of cash to console
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine("{0} has {1} bucks.", Name, Cash);
        }

        /// <summary>
        /// Gives cash, removing from wallet if enough, prints error if not
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        /// <returns>The amount of cash removed from wallet or 0 if there was not enough cash</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("{0} says {1} isn't a valid number.", Name, amount);
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine("{0} says: \"I don't have enough cash to give you {1}.\"");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Receives cash and adds to wallet
        /// </summary>
        /// <param name="amount">Amount of money to receive</param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
                Console.WriteLine("{0} says: {1} isn't an amount I'll take.");
            else
                Cash += amount;
        }
    }
}
