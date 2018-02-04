using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootTableApplication
{
    class LootRollData
    {
        /*
         * Request: Create an application in which the user can press a button, which rolls a number 1 - 100, which selects
         * a category based on the number rolled. Then, after it determines the category, it should roll another number
         * 1 - 100, which then determines the reward in said category. 
         *
         * If the number rolled is 100, roll twice. So, we might use a rollsLeft variable there.
         * 
         */

        // Property declarations

        public int CategoryNumberRoll { get; set; }
        public string Category { get; set; }
        public int RewardNumberRoll { get; set; }
        public string RewardDescription { get; set; }

        public LootRollData()
        {

        }
        
        public LootRollData(int newCatNumber, string newCat, int newReward, string newRewardDesc)
        {
            CategoryNumberRoll = newCatNumber;
            Category = newCat;
            RewardNumberRoll = newReward;
            RewardDescription = newRewardDesc;
        }

    }
}
