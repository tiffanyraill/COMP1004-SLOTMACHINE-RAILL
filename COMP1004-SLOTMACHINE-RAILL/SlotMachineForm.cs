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
        private void resetCardTally()
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
          //  leftPictureBox.BackColor = Color.Transparent;
           // middlePictureBox.BackColor = Color.Transparent;
            //rightPictureBox.BackColor = Color.Transparent;
            //   leftPictureBox.BackColor = Color.White;
            // middlePictureBox.BackColor = Color.White;
            //  rightPictureBox.BackColor = Color.White;

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
            WinLossTextBox.Text = "You Win!";
            PayoutTextBox.Text = "" + winnings;
            resetCardTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            
            WinLossTextBox.Text = "Play Again";
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
                    betLine[spin] = "Blank";
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

            leftPictureBox.Visible = true;
            middlePictureBox.Visible = true;
            rightPictureBox.Visible = true;

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
                updatePictureBoxes();
                determineWinnings();
                turn++;
                
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
            leftPictureBox.BackColor = Color.White;
            middlePictureBox.BackColor = Color.White;
            rightPictureBox.BackColor = Color.White;
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
            if (spinResult[0] == "Hearts")
            {
                leftPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.heart;
                leftPictureBox.BackColor = Color.White;
            }
            else if (spinResult[0] == "Diamonds")
            {
                leftPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.diamond;
                leftPictureBox.BackColor = Color.White;
            }
            else if (spinResult[0] == "Clubs")
            {
                leftPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.club;
                leftPictureBox.BackColor = Color.White;
            }
            else if (spinResult[0] == "Spades")
            {
                leftPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.spade;
                leftPictureBox.BackColor = Color.White;
            }
            else if (spinResult[0] == "Jokers")
            {
                leftPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.jokerblack;
                leftPictureBox.BackColor = Color.White;
            }
            else if (spinResult[0] == "Blank")
            {
                leftPictureBox.BackColor = Color.White;
            }
            //middle reel
            if (spinResult[1] == "Hearts")
            {
                middlePictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.heart;
                middlePictureBox.BackColor = Color.White;
            }
            else if (spinResult[1] == "Diamonds")
            {
                middlePictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.diamond;
                middlePictureBox.BackColor = Color.White;
            }
            else if (spinResult[1] == "Clubs")
            {
                middlePictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.club;
                middlePictureBox.BackColor = Color.White;
            }
            else if (spinResult[1] == "Spades")
            {
                middlePictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.spade;
                middlePictureBox.BackColor = Color.White;
            }
            else if (spinResult[1] == "Jokers")
            {
                middlePictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.jokerblack;
                middlePictureBox.BackColor = Color.White;
            }
            else if (spinResult[1] == "Blank")
            {
                middlePictureBox.BackColor = Color.White;
            }
            //right reel
            if (spinResult[2] == "Hearts")
            {
                rightPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.heart;
                rightPictureBox.BackColor = Color.White;
            }
            else if (spinResult[2] == "Diamonds")
            {
                rightPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.diamond;
                rightPictureBox.BackColor = Color.White;
            }
            else if (spinResult[2] == "Clubs")
            {
                rightPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.club;
                rightPictureBox.BackColor = Color.White;
            }
            else if (spinResult[2] == "Spades")
            {
                rightPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.spade;
                rightPictureBox.BackColor = Color.White;
            }
            else if (spinResult[2] == "Jokers")
            {
                rightPictureBox.Image = COMP1004_SLOTMACHINE_RAILL.Properties.Resources.jokerblack;
                rightPictureBox.BackColor = Color.White;
            }
            else if (spinResult[2] == "Blank")
            {
                rightPictureBox.BackColor = Color.White;
            }
        }

        /*
         *  Update labels & check if the spin button should be disabled
         */
        private void updateLabels()
        {
            PayoutTextBox.Text = "" + playerMoney;
            BetTextBox.Text = "" + playerBet;
            jackpotLabel.Text = "Jackpot: " + jackpot;
            if (playerBet == 0)
            {
                startButton.Image = Properties.Resources.greenGo;
                startButton.Enabled = false;
                startButton.Visible = false;
            }
            else if (playerBet > 0)
            {
                startButton.Image = Properties.Resources.greenGo;
                startButton.Enabled = true;
                startButton.Visible = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetAll();
            updateLabels();
            leftPictureBox.Visible = false;
            middlePictureBox.Visible = false;
            rightPictureBox.Visible = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            showPlayerStats();
            Application.Exit();
        }

    }
}
