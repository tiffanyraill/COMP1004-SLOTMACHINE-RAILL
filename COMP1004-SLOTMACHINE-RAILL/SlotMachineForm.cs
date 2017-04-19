using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_SLOTMACHINE_RAILL
{
    public partial class SlotMachineForm : Form
    {
        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string cards = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int hearts = 0;
        private int spades = 0;
        private int diamonds = 0;
        private int clubs = 0;
        private int blanks = 0;
        private int jokers = 0;

        Random random = new Random();
        public SlotMachineForm()
        {
            InitializeComponent();
            updateLabels();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            MessageBox.Show(stats, "Player Stats");
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            hearts = 0;
            diamonds = 0;
            clubs = 0;
            spades = 0;
            jokers = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            playerMoney = 1000;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 0;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;
            WinLossTextBox.Text = "";
            PayoutTextBox.Text = "";
            leftPictureBox.BackColor = Color.Transparent;
            middlePictureBox.BackColor = Color.Transparent;
            rightPictureBox.BackColor = Color.Transparent;

        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                //update the labels
                WinLossTextBox.Text = "JACKPOT!!";
                PayoutTextBox.Text = "" + winnings + jackpot;
                playerMoney += jackpot;
                jackpot = 1000;
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            //message boxes have been replaced with labels
            WinLossTextBox.Text = "WINNER!";
            PayoutTextBox.Text = "" + winnings;
            resetCardTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            //message boxes have been replaced with labels
            WinLossTextBox.Text = "TRY AGAIN!";
            PayoutTextBox.Text = "";
            playerMoney -= playerBet;
            resetCardTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;

        }

        /* When this function is called it determines the betLine results.
         e.g. Hearts - Diamonds - clubs */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };
            int[] outCome = { 0, 0, 0 };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(55) + 1;

                if (checkRange(outCome[spin], 1, 23))
                {  // 41.2% probability
                    betLine[spin] = "blank";
                    blanks++;
                }
                else if (checkRange(outCome[spin], 24, 35))
                { // 21.8% probability
                    betLine[spin] = "Hearts";
                    hearts++;
                }
                else if (checkRange(outCome[spin], 36, 44))
                { // 16.4% probability
                    betLine[spin] = "Diamonds";
                    diamonds++;
                }
                else if (checkRange(outCome[spin], 45, 52))
                { // 14.5% probability
                    betLine[spin] = "Clubs";
                    clubs++;
                }
                else if (checkRange(outCome[spin], 53, 54))
                { //  3.6% probability
                    betLine[spin] = "Spades";
                    spades++;
                }
                else if (checkRange(outCome[spin], 55, 55))
                { //  1.8% probability
                    betLine[spin] = "Joker";
                    jokers++;

                }
            }
            return betLine;
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (hearts == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (diamonds == 3)
                {
                    winnings = playerBet * 25;
                }
                else if (clubs == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (spades == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (jokers == 3)
                {
                    winnings = playerBet * 100;
                }
               
                else if (hearts == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (diamonds == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (clubs == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (spades == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (jokers == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (jokers == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }

        }
        private void startButton_Click(object sender, EventArgs e)
        {

            leftPictureBox.BackColor = Color.White;
            middlePictureBox.BackColor = Color.White;
            rightPictureBox.BackColor = Color.White;

            playerBet = 10; // default bet amount

            if (playerMoney == 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                    showPlayerStats();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }
            else if (playerBet < 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
                spinResult = Reels();
                cards = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2];
                MessageBox.Show(cards);
                determineWinnings();
                turn++;
                showPlayerStats();
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount");
            }

        }

        private void bet1PictureBox_Click(object sender, EventArgs e)
        {
            playerBet = 1;
            updateLabels();
        }
        private void bet5PictureBox_Click(object sender, EventArgs e)
        {
            playerBet = 5;
            updateLabels();
        }

        private void bet10PictureBox_Click(object sender, EventArgs e)
        {
            playerBet = 10;
            updateLabels();
        }

        private void bet25PictureBox_Click(object sender, EventArgs e)
        {
            playerBet = 25;
            updateLabels();
        }

          /* This function will update the reels based on the results */
          private void updatePictureBoxes()
             {
            //left reel
            if (spinResult[0] == "hearts")
            {
                leftPictureBox.Image = Properties.Resources.heart;
            }
            else if (spinResult[0] == "diamonds")
            {
                leftPictureBox.Image = Properties.Resources.diamond;
            }
            else if (spinResult[0] == "clubs")
            {
                leftPictureBox.Image = Properties.Resources.club;
            }
            else if (spinResult[0] == "spades")
            {
                leftPictureBox.Image = Properties.Resources.spade;
            }
            else if (spinResult[0] == "jokers")
            {
                leftPictureBox.Image = Properties.Resources.jokerblack;
            }
            //middle reel
            if (spinResult[1] == "hearts")
            {
                middlePictureBox.Image = Properties.Resources.heart;
            }
            else if (spinResult[1] == "diamonds")
            {
                middlePictureBox.Image = Properties.Resources.diamond;
            }
            else if (spinResult[1] == "clubs")
            {
                middlePictureBox.Image = Properties.Resources.club;
            }
            else if (spinResult[1] == "spades")
            {
                middlePictureBox.Image = Properties.Resources.spade;
            }
            else if (spinResult[1] == "jokers")
            {
                middlePictureBox.Image = Properties.Resources.jokerblack;
            }

        }
            for (int mSpin = 0; mSpin < 1; mSpin++)
            {
                mSpin = this.random.Next(3) + 1;

                if (mSpin == 1)
                {
                    middlePictureBox.Image = Properties.Resources.heart;
                }
                else if (mSpin == 2)
                {
                    middlePictureBox.Image = Properties.Resources.spade;
                }
                else if (mSpin == 3)
                {
                    middlePictureBox.Image = Properties.Resources.diamond;
                }
                else if (mSpin == 4)
                {
                    middlePictureBox.Image = Properties.Resources.club;
                }
            }
            for (int rSpin = 0; rSpin < 1; rSpin++)
            {
                rSpin = this.random.Next(3) + 1;

                if (rSpin == 1)
                {
                   rightPictureBox.Image = Properties.Resources.heart;

                }
                else if (rSpin == 2)
                {
                     rightPictureBox.Image = Properties.Resources.spade;

                }
                else if (rSpin == 3)
                {
                    rightPictureBox.Image = Properties.Resources.diamond;
                }
                else if (rSpin == 4)
                {
                    rightPictureBox.Image = Properties.Resources.club;
                }
            }

        }

        /*
         * This will update all the labels in the form, as well as check if the spin button should be disabled
         */
        private void updateLabels()
        {
            MoneyLabel.Text = "" + playerMoney;
            BetLabel.Text = "" + playerBet;
            JackpotLabel.Text = "Jackpot: " + jackpot;
            if (playerBet == 0)
            {
                SpinPictureBox.Image = SlotMachine.Properties.Resources.spin_disabled;
            }
            else if (playerBet > 0)
            {
                SpinPictureBox.Image = SlotMachine.Properties.Resources.spin;
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            resetAll();
            updateLabels();
           
        }

    }
}
