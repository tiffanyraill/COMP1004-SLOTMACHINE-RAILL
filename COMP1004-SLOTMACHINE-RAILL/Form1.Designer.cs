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
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.greenGo;
            this.startButton.Location = new System.Drawing.Point(468, 583);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 138);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BackColor = System.Drawing.Color.White;
            this.leftPictureBox.Location = new System.Drawing.Point(188, 291);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(154, 130);
            this.leftPictureBox.TabIndex = 1;
            this.leftPictureBox.TabStop = false;
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.BackColor = System.Drawing.Color.White;
            this.middlePictureBox.Location = new System.Drawing.Point(373, 291);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(154, 130);
            this.middlePictureBox.TabIndex = 2;
            this.middlePictureBox.TabStop = false;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BackColor = System.Drawing.Color.White;
            this.rightPictureBox.Location = new System.Drawing.Point(559, 291);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(154, 130);
            this.rightPictureBox.TabIndex = 3;
            this.rightPictureBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Image = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.orangeReset1;
            this.resetButton.Location = new System.Drawing.Point(272, 583);
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
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::COMP1004_SLOTMACHINE_RAILL.Properties.Resources.slot_machine_clip_art;
            this.ClientSize = new System.Drawing.Size(944, 725);
            this.ControlBox = false;
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
         //   this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox startButton;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.PictureBox resetButton;
        private System.Windows.Forms.PictureBox exitButton;
    }
}

