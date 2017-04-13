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
        Random random = new Random();
        public SlotMachineForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            leftPictureBox.BackColor = Color.White;
            middlePictureBox.BackColor = Color.White;
            rightPictureBox.BackColor = Color.White;


            //  int result = 0;

            for (int lSpin = 0; lSpin < 1; lSpin++)
            {
                lSpin = this.random.Next(3) + 1;

                if (lSpin == 1)
                {
                    leftPictureBox.Image = Properties.Resources.heart;
                }
                else if (lSpin == 2)
                {
                    leftPictureBox.Image = Properties.Resources.spade;
                }
                else if (lSpin == 3)
                {
                    leftPictureBox.Image = Properties.Resources.diamond;
                }
                else if (lSpin == 4)
                {
                    leftPictureBox.Image = Properties.Resources.heart;
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
        

        private void resetButton_Click(object sender, EventArgs e)
        {
            
            leftPictureBox.BackColor = Color.White;
            middlePictureBox.BackColor = Color.White;
            rightPictureBox.BackColor = Color.White;
        }
    }
}
