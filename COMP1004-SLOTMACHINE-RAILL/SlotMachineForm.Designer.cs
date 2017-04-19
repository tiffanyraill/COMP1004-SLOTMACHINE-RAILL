namespace COMP1004_SLOTMACHINE_RAILL
{
    partial class SlotMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.PictureBox();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.WinLossTextBox = new System.Windows.Forms.TextBox();
            this.PayoutTextBox = new System.Windows.Forms.TextBox();
            this.bet1PictureBox = new System.Windows.Forms.PictureBox();
            this.bet5PictureBox = new System.Windows.Forms.PictureBox();
            this.bet10PictureBox = new System.Windows.Forms.PictureBox();
            this.bet25PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet10PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet25PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.greenGo;
            this.startButton.Location = new System.Drawing.Point(702, 655);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 138);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.leftPictureBox.Location = new System.Drawing.Point(188, 291);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(154, 130);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPictureBox.TabIndex = 1;
            this.leftPictureBox.TabStop = false;
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.middlePictureBox.Location = new System.Drawing.Point(373, 291);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(154, 130);
            this.middlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middlePictureBox.TabIndex = 2;
            this.middlePictureBox.TabStop = false;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rightPictureBox.Location = new System.Drawing.Point(559, 291);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(154, 130);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightPictureBox.TabIndex = 3;
            this.rightPictureBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.orangeReset1;
            this.resetButton.Location = new System.Drawing.Point(34, 655);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(168, 140);
            this.resetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetButton.TabIndex = 4;
            this.resetButton.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.exit;
            this.exitButton.Location = new System.Drawing.Point(836, -5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 102);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BetTextBox
            // 
            this.BetTextBox.BackColor = System.Drawing.Color.Black;
            this.BetTextBox.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTextBox.ForeColor = System.Drawing.Color.Red;
            this.BetTextBox.Location = new System.Drawing.Point(384, 563);
            this.BetTextBox.MaxLength = 6;
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.ReadOnly = true;
            this.BetTextBox.Size = new System.Drawing.Size(143, 49);
            this.BetTextBox.TabIndex = 6;
            // 
            // WinLossTextBox
            // 
            this.WinLossTextBox.BackColor = System.Drawing.Color.Black;
            this.WinLossTextBox.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLossTextBox.ForeColor = System.Drawing.Color.Red;
            this.WinLossTextBox.Location = new System.Drawing.Point(199, 563);
            this.WinLossTextBox.MaxLength = 100;
            this.WinLossTextBox.Name = "WinLossTextBox";
            this.WinLossTextBox.ReadOnly = true;
            this.WinLossTextBox.Size = new System.Drawing.Size(143, 49);
            this.WinLossTextBox.TabIndex = 7;
            // 
            // PayoutTextBox
            // 
            this.PayoutTextBox.BackColor = System.Drawing.Color.Black;
            this.PayoutTextBox.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayoutTextBox.ForeColor = System.Drawing.Color.Red;
            this.PayoutTextBox.Location = new System.Drawing.Point(559, 563);
            this.PayoutTextBox.MaxLength = 6;
            this.PayoutTextBox.Name = "PayoutTextBox";
            this.PayoutTextBox.ReadOnly = true;
            this.PayoutTextBox.Size = new System.Drawing.Size(143, 49);
            this.PayoutTextBox.TabIndex = 8;
            // 
            // bet1PictureBox
            // 
            this.bet1PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bet1PictureBox.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.bet1;
            this.bet1PictureBox.Location = new System.Drawing.Point(244, 631);
            this.bet1PictureBox.Name = "bet1PictureBox";
            this.bet1PictureBox.Size = new System.Drawing.Size(98, 86);
            this.bet1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bet1PictureBox.TabIndex = 9;
            this.bet1PictureBox.TabStop = false;
            this.bet1PictureBox.Click += new System.EventHandler(this.bet1PictureBox_Click);
            // 
            // bet5PictureBox
            // 
            this.bet5PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bet5PictureBox.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.bet5;
            this.bet5PictureBox.Location = new System.Drawing.Point(352, 631);
            this.bet5PictureBox.Name = "bet5PictureBox";
            this.bet5PictureBox.Size = new System.Drawing.Size(98, 86);
            this.bet5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bet5PictureBox.TabIndex = 10;
            this.bet5PictureBox.TabStop = false;
            this.bet5PictureBox.Click += new System.EventHandler(this.bet5PictureBox_Click);
            // 
            // bet10PictureBox
            // 
            this.bet10PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bet10PictureBox.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.bet10;
            this.bet10PictureBox.Location = new System.Drawing.Point(456, 631);
            this.bet10PictureBox.Name = "bet10PictureBox";
            this.bet10PictureBox.Size = new System.Drawing.Size(98, 86);
            this.bet10PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bet10PictureBox.TabIndex = 11;
            this.bet10PictureBox.TabStop = false;
            this.bet10PictureBox.Click += new System.EventHandler(this.bet10PictureBox_Click);
            // 
            // bet25PictureBox
            // 
            this.bet25PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bet25PictureBox.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.bet25;
            this.bet25PictureBox.Location = new System.Drawing.Point(559, 631);
            this.bet25PictureBox.Name = "bet25PictureBox";
            this.bet25PictureBox.Size = new System.Drawing.Size(98, 86);
            this.bet25PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bet25PictureBox.TabIndex = 12;
            this.bet25PictureBox.TabStop = false;
            this.bet25PictureBox.Click += new System.EventHandler(this.bet25PictureBox_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.slot_machine_clip_art;
            this.ClientSize = new System.Drawing.Size(944, 795);
            this.ControlBox = false;
            this.Controls.Add(this.bet25PictureBox);
            this.Controls.Add(this.bet10PictureBox);
            this.Controls.Add(this.bet5PictureBox);
            this.Controls.Add(this.bet1PictureBox);
            this.Controls.Add(this.PayoutTextBox);
            this.Controls.Add(this.WinLossTextBox);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.middlePictureBox);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet10PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet25PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox startButton;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.PictureBox resetButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.TextBox BetTextBox;
        private System.Windows.Forms.TextBox WinLossTextBox;
        private System.Windows.Forms.TextBox PayoutTextBox;
        private System.Windows.Forms.PictureBox bet1PictureBox;
        private System.Windows.Forms.PictureBox bet5PictureBox;
        private System.Windows.Forms.PictureBox bet10PictureBox;
        private System.Windows.Forms.PictureBox bet25PictureBox;
    }
}

