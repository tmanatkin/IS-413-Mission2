using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class RollDice
    {
        public int[] Roll(int numRolls)
        {
            // Initialize Variables
            int[] diceRollCounts = new int[11];
            Random random = new Random();

            // Roll Dice
            for (int i = 0; i < numRolls; i++)
            {
                int diceRoll = random.Next(1, 7) + random.Next(1, 7);
                diceRollCounts[diceRoll - 2]++;
            }

            // Return Dice Roll Counts Array
            return diceRollCounts;
        }

    }
}
