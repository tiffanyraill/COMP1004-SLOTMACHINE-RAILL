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

        private int spin3oK()
        {
            int result = 0;
            for (int spin = 0; spin < 1; spin++)
            {
                result += random.Next(1, 3);
            }
            return result;

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

        }
    }
}
