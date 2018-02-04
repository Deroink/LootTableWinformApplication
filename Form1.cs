using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LootTableApplication
{
    public partial class Form1 : Form
    {

        BindingList<LootRollData> rollData = new BindingList<LootRollData>();

        public int rollsLeft = 1;

        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            // Clear data
            RollResultsDataGrid.Rows.Clear();
            
            Random random = new Random();

            // Sample Data
            rollData.Add(new LootRollData() { CategoryNumberRoll = random.Next(0, 100), Category = "Sample Data", RewardNumberRoll = 255, RewardDescription = "Ignore this" });
            rollData.Add(new LootRollData() { CategoryNumberRoll = 4122, Category = "Dafwfewfr", RewardNumberRoll = 25315, RewardDescription = "drefdsfam" });
            RollResultsDataGrid.DataSource = rollData;

            // Setting individual column width, instead of autosizing, for various purposes.
            RollResultsDataGrid.Columns[0].Width = 113;
            RollResultsDataGrid.Columns[1].Width = 150;
            RollResultsDataGrid.Columns[2].Width = 105;
            RollResultsDataGrid.Columns[3].Width = 550;
        }

        private void btnRollTheDice_Click(object sender, EventArgs e)
        {
            RollResultsDataGrid.Rows.Clear();
            getRollData();
            rollsLeft--;
            LabelRollsLeft.Text = "Rolls Left: " + rollsLeft.ToString();
        }

        private void getRollData()
        {
            Random newRand = new Random();
            
            // Declare variables needed for the object to be added.
            int categoryRoll = 0;
            int rewardRoll = 0;
            string category = "";
            string rewardDescription = "";


            
            // Get a random number for both category and reward of the category, this avoids bugs.
            for (int i = 0; i < 5; i++)
            {
                categoryRoll = newRand.Next(1, 100);
                rewardRoll = newRand.Next(1, 100);
            }
            // Get the category label, then the reward within the category.
            category = getCategoryFromRoll(categoryRoll);
            rewardDescription = getRewardFromRoll(category, rewardRoll);

            // Finally, send all collected data to the list, which is then added to the DGV.
            rollData.Add(new LootRollData() { CategoryNumberRoll = categoryRoll, Category = category, RewardNumberRoll = rewardRoll, RewardDescription = rewardDescription });
        }

        private string getCategoryFromRoll(int categoryRoll)
        {
            string category;

            if (categoryRoll >= 1 && categoryRoll <= 20)
            {
                category = "Gold";
            }
            else if (categoryRoll >= 21 && categoryRoll <= 40)
            {
                category = "Weapons";
            }
            else if (categoryRoll >= 41 && categoryRoll <= 60)
            {
                category = "Armor";
            }
            else if (categoryRoll >= 61 && categoryRoll <= 70)
            {
                category = "Mounts";
            }
            else if (categoryRoll >= 71 && categoryRoll <= 80)
            {
                category = "Potions";
            }
            else if (categoryRoll >= 81 && categoryRoll <= 90)
            {
                category = "Rings";
            }
            else if (categoryRoll >= 91 && categoryRoll <= 95)
            {
                category = "Scroll";
            }
            else if (categoryRoll >= 96 && categoryRoll <= 99)
            {
                category = "Wonder Items";
            }
            else if (categoryRoll == 100)
            {
                category = "Roll Twice";
                rollsLeft += 2;
            }
            else
            {
                category = "Derek fucked up";
            }


            return category;
        }

        private string getRewardFromRoll(string theCategory, int theRewardRoll)
        {
            string rewardString = "";

            switch(theCategory)
            {
                case "Gold":
                    rewardString = getGoldReward(theRewardRoll);
                    break;
                case "Weapons":
                    rewardString = getWeaponReward(theRewardRoll);
                    break;
                case "Armor":
                    rewardString = getArmorReward(theRewardRoll);
                    break;
                case "Mounts":
                    rewardString = getMountReward(theRewardRoll);
                    break;
                case "Potions":
                    rewardString = getPotionReward(theRewardRoll);
                    break;
                case "Rings":
                    rewardString = getRingReward(theRewardRoll);
                    break;
                case "Scroll":
                    rewardString = getScrollReward(theRewardRoll);
                    break;
                case "Wonder Items":
                    rewardString = getWonderReward(theRewardRoll);
                    break;
                case "Roll Twice":
                    rewardString = "Rolled a 100. Increasing number of rolls left by 2.";
                    break;
            }
            return rewardString;
        }

        private string getGoldReward(int theRoll)
        {
            // Because gold uses random amounts of money generated, a random roll is necessary to create an accurate string.
            Random randomMoneyGained = new Random();
            int randomMoney = 0;

            for(int i = 0; i < 5; i++)
            {
                randomMoney = randomMoneyGained.Next(1, 100);
            }
            string theRewardDescription = "";
            

            if(theRoll >= 1 && theRoll <= 40)
            {
                theRewardDescription = $"The player gains {randomMoney} copper.";
            }
            else if (theRoll >= 41 && theRoll <= 80)
            {
                theRewardDescription = $"The player gains {randomMoney} silver.";
            }
            else if (theRoll >= 81 && theRoll <= 89)
            {
                theRewardDescription = $"The player gains {randomMoney} gold.";
            }
            else if (theRoll >= 90 && theRoll <= 98)
            {
                theRewardDescription = $"The player gains {randomMoney} platinum.";
            }
            else if (theRoll >= 99 && theRoll <= 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }


            return theRewardDescription;
        }

        private string getWeaponReward(int theRoll)
        {
            string theRewardDescription = "";


            if (theRoll >= 1 && theRoll <= 25)
            {
                theRewardDescription = "The player gains a melee weapon.";
            }
            else if (theRoll >= 26 && theRoll <= 50)
            {
                theRewardDescription = "The player gains a ranged weapon.";
            }
            else if (theRoll >= 51 && theRoll <= 70)
            {
                theRewardDescription = "The player gains a magical melee weapon.";
            }
            else if (theRoll >= 71 && theRoll <= 90)
            {
                theRewardDescription = "The player gains a magical ranged weapon.";
            }
            else if (theRoll >= 91 && theRoll <= 99)
            {
                theRewardDescription = "The player gains a GM special weapon.";
            }
            else if (theRoll == 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }


            return theRewardDescription;
        }

        private string getArmorReward(int theRoll)
        {
            string theRewardDescription = "";


            if (theRoll >= 1 && theRoll <= 15)
            {
                theRewardDescription = "The player gains a set of light armor.";
            }
            else if (theRoll >= 16 && theRoll <= 30)
            {
                theRewardDescription = "The player gains a set of medium armor";
            }
            else if (theRoll >= 31 && theRoll <= 45)
            {
                theRewardDescription = "The player gains a set of heavy armor.";
            }
            else if (theRoll >= 46 && theRoll <= 59)
            {
                theRewardDescription = "The player gains a set of magical light armor.";
            }
            else if (theRoll >= 60 && theRoll <= 73)
            {
                theRewardDescription = "The player gains a set of magical medium armor.";
            }
            else if (theRoll >= 74 && theRoll <= 87)
            {
                theRewardDescription = "The player gains a set of magical heavy armor.";
            }
            else if (theRoll >= 88 && theRoll <= 97)
            {
                theRewardDescription = "The player gains a special GM armor piece.";
            }
            else if (theRoll >= 98 && theRoll <= 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }


            return theRewardDescription;
        }

        private string getMountReward(int theRoll)
        {
            string theRewardDescription = "";


            if (theRoll >= 1 && theRoll <= 50)
            {
                theRewardDescription = "The player gains a slow speed mount.";
            }
            else if (theRoll >= 51 && theRoll <= 75)
            {
                theRewardDescription = "The player gains a medium speed mount.";
            }
            else if (theRoll >= 76 && theRoll <= 90)
            {
                theRewardDescription = "The player gains a fast speed mount.";
            }
            else if (theRoll >= 91 && theRoll <= 96)
            {
                theRewardDescription = "The player gains a special GM mount.";
            }
            else if (theRoll >= 97 && theRoll <= 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }


            return theRewardDescription;
        }

        private string getPotionReward(int theRoll)
        {
            string theRewardDescription = "";
            
            if (theRoll >= 1 && theRoll <= 20)
            {
                theRewardDescription = "The player gains a potion of cure 1d8.";
            }
            else if (theRoll >= 21 && theRoll <= 30)
            {
                theRewardDescription = "The player gains a potion of cure 2d8.";
            }
            else if (theRoll >= 31 && theRoll <= 36)
            {
                theRewardDescription = "The player gains a potion of cure 3d8.";
            }
            else if (theRoll >= 37 && theRoll <= 56)
            {
                theRewardDescription = "The player gains a buff potion, rank 1.";
            }
            else if (theRoll >= 57 && theRoll <= 66)
            {
                theRewardDescription = "The player gains a buff potion, rank 2.";
            }
            else if (theRoll >= 67 && theRoll <= 72)
            {
                theRewardDescription = "The player gains a buff potion, rank 3.";
            }
            else if (theRoll >= 73 && theRoll <= 87)
            {
                theRewardDescription = "The player gains a debuff potion, rank 1.";
            }
            else if (theRoll >= 88 && theRoll <= 92)
            {
                theRewardDescription = "The player gains a debuff potion, rank 2.";
            }
            else if (theRoll >= 93 && theRoll <= 94)
            {
                theRewardDescription = "The player gains a debuff potion, rank 3.";
            }
            else if (theRoll >= 95 && theRoll <= 99)
            {
                theRewardDescription = "The player gains a special GM potion.";
            }
            else if (theRoll == 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }


            return theRewardDescription;
        }

        private string getRingReward(int theRoll)
        {
            string theRewardDescription = "";

            if (theRoll >= 1 && theRoll <= 30)
            {
                theRewardDescription = "The player gains a ring, rank 1.";
            }
            else if (theRoll >= 31 && theRoll <= 55)
            {
                theRewardDescription = "The player gains a ring, rank 2.";
            }
            else if (theRoll >= 56 && theRoll <= 70)
            {
                theRewardDescription = "The player gains a ring, rank 3.";
            }
            else if (theRoll >= 71 && theRoll <= 80)
            {
                theRewardDescription = "The player gains a ring, rank 4.";
            }
            else if (theRoll >= 81 && theRoll <= 85)
            {
                theRewardDescription = "The player gains a ring, rank 5.";
            }
            else if (theRoll >= 86 && theRoll <= 95)
            {
                theRewardDescription = "The player 'gains' a cursed ring. That sucks.";
            }
            else if (theRoll >= 96 && theRoll <= 98)
            {
                theRewardDescription = "The player gains a special GM ring.";
            }
            else if (theRoll >= 99 && theRoll <= 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }


            return theRewardDescription;
        }

        private string getScrollReward(int theRoll)
        {
            string theRewardDescription = "";

            if (theRoll >= 1 && theRoll <= 30)
            {
                theRewardDescription = "The player gains a spell 1-3 scroll.";
            }
            else if (theRoll >= 31 && theRoll <= 55)
            {
                theRewardDescription = "The player gains a spell 4-6 scroll.";
            }
            else if (theRoll >= 56 && theRoll <= 75)
            {
                theRewardDescription = "The player gains a spell 7-9 scroll.";
            }
            else if (theRoll >= 76 && theRoll <= 85)
            {
                theRewardDescription = "The player gains a bad spell 1-3 scroll.";
            }
            else if (theRoll >= 86 && theRoll <= 93)
            {
                theRewardDescription = "The player gains a bad spell 4 - 6 scroll.";
            }
            else if (theRoll >= 94 && theRoll <= 99)
            {
                theRewardDescription = "The player gains a bad spell 7 - 9 scroll";
            }
            else if (theRoll == 100)
            {
                rollsLeft += 2;
                theRewardDescription = "Increased remaining rolls by 2.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }
            
            return theRewardDescription;
        }

        private string getWonderReward(int theRoll)
        {
            string theRewardDescription = "";

            if (theRoll >= 1 && theRoll <= 35)
            {
                theRewardDescription = "The player gains a wondrous item of rare quality.";
            }
            else if (theRoll >= 36 && theRoll <= 65)
            {
                theRewardDescription = "The player gains a wondrous item of epic quality.";
            }
            else if (theRoll >= 66 && theRoll <= 75)
            {
                theRewardDescription = "The player gains a wondrous item of legendary quality.";
            }
            else if (theRoll >= 76 && theRoll <= 80)
            {
                theRewardDescription = "The player gains a wondrous item of ancient quality.";
            }
            else if (theRoll >= 81 && theRoll <= 90)
            {
                theRewardDescription = "The player gains a wondrous special GM rare item.";
            }
            else if (theRoll >= 91 && theRoll <= 95)
            {
                theRewardDescription = "The player gains a wondrous special GM epic item.";
            }
            else if (theRoll >= 96 && theRoll <= 98)
            {
                theRewardDescription = "The player gains a wondrous special GM legendary item.";
            }
            else if (theRoll >= 99 && theRoll <= 100)
            {
                theRewardDescription = "The player gains a wondrous special GM ancient item.";
            }
            else
            {
                theRewardDescription = "Derek fucked up.";
            }

            return theRewardDescription;
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basically, the program rolls a number to pick a category, then rolls a number from there to pick a reward" +
                "from said category. \nDepending on the number rolled in certain cases, more rolls will be taken." +
                "\n\nI had a bug with the rolls left variable, so I added a workaround to display how many rolls are left." +
                "If it hits 0, the rolls for the player are done. If for whatever reason you need to, there's a button to reset the roll" +
                "count.");
        }

        private void BtnResetRollCount_Click(object sender, EventArgs e)
        {
            rollsLeft = 1;
            LabelRollsLeft.Text = "Rolls Left: " + rollsLeft.ToString();
        }
    }
}
