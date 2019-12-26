namespace PacmanSasha
{
    partial class frmInstructions
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.lblLuck = new System.Windows.Forms.Label();
            this.picPacman = new System.Windows.Forms.PictureBox();
            this.picControls = new System.Windows.Forms.PictureBox();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBack = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControls)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(291, 36);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(202, 39);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Instructions";
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRule1.Location = new System.Drawing.Point(15, 91);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(557, 23);
            this.lblRule1.TabIndex = 1;
            this.lblRule1.Text = "1. Get all of the coins without colliding into the ghosts to win";
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule2.ForeColor = System.Drawing.Color.Yellow;
            this.lblRule2.Location = new System.Drawing.Point(15, 131);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(440, 23);
            this.lblRule2.TabIndex = 2;
            this.lblRule2.Text = "2. Colliding into a ghost results in a loss of a life";
            // 
            // lblRule3
            // 
            this.lblRule3.AutoSize = true;
            this.lblRule3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule3.ForeColor = System.Drawing.Color.Red;
            this.lblRule3.Location = new System.Drawing.Point(15, 174);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(380, 23);
            this.lblRule3.TabIndex = 3;
            this.lblRule3.Text = "3. Losing all three lives means game over";
            // 
            // lblRule4
            // 
            this.lblRule4.AutoSize = true;
            this.lblRule4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRule4.Location = new System.Drawing.Point(15, 216);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(443, 23);
            this.lblRule4.TabIndex = 4;
            this.lblRule4.Text = "4. Bumping into the walls leads you to the start";
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuck.ForeColor = System.Drawing.Color.White;
            this.lblLuck.Location = new System.Drawing.Point(344, 258);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(97, 23);
            this.lblLuck.TabIndex = 5;
            this.lblLuck.Text = "Good luck!";
            // 
            // picPacman
            // 
            this.picPacman.Image = global::PacmanSasha.Properties.Resources.Instructions;
            this.picPacman.Location = new System.Drawing.Point(272, 325);
            this.picPacman.Name = "picPacman";
            this.picPacman.Size = new System.Drawing.Size(247, 160);
            this.picPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacman.TabIndex = 6;
            this.picPacman.TabStop = false;
            // 
            // picControls
            // 
            this.picControls.Image = global::PacmanSasha.Properties.Resources.ArrowKeys;
            this.picControls.Location = new System.Drawing.Point(586, 78);
            this.picControls.Name = "picControls";
            this.picControls.Size = new System.Drawing.Size(202, 161);
            this.picControls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControls.TabIndex = 7;
            this.picControls.TabStop = false;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.Color.White;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.Color.Red;
            this.lblControls.Location = new System.Drawing.Point(594, 91);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(69, 16);
            this.lblControls.TabIndex = 8;
            this.lblControls.Text = "Controls:";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.BackColor = System.Drawing.Color.White;
            this.lblUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.ForeColor = System.Drawing.Color.Black;
            this.lblUp.Location = new System.Drawing.Point(678, 91);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(28, 16);
            this.lblUp.TabIndex = 9;
            this.lblUp.Text = "Up";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.White;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.Black;
            this.lblLeft.Location = new System.Drawing.Point(609, 135);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(33, 16);
            this.lblLeft.TabIndex = 10;
            this.lblLeft.Text = "Left";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.White;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.ForeColor = System.Drawing.Color.Black;
            this.lblRight.Location = new System.Drawing.Point(727, 131);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(44, 16);
            this.lblRight.TabIndex = 11;
            this.lblRight.Text = "Right";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.BackColor = System.Drawing.Color.White;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.ForeColor = System.Drawing.Color.Black;
            this.lblDown.Location = new System.Drawing.Point(669, 205);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(46, 16);
            this.lblDown.TabIndex = 12;
            this.lblDown.Text = "Down";
            // 
            // mnuOptions
            // 
            this.mnuOptions.BackColor = System.Drawing.Color.White;
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniBack});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(800, 24);
            this.mnuOptions.TabIndex = 13;
            this.mnuOptions.Text = "Options";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(38, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniBack
            // 
            this.mniBack.Name = "mniBack";
            this.mniBack.Size = new System.Drawing.Size(44, 20);
            this.mniBack.Text = "Back";
            this.mniBack.Click += new System.EventHandler(this.mniBack_Click);
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.picControls);
            this.Controls.Add(this.picPacman);
            this.Controls.Add(this.lblLuck);
            this.Controls.Add(this.lblRule4);
            this.Controls.Add(this.lblRule3);
            this.Controls.Add(this.lblRule2);
            this.Controls.Add(this.lblRule1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.mnuOptions);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmInstructions";
            this.Text = "Simple Pacman Game by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControls)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRule4;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.PictureBox picPacman;
        private System.Windows.Forms.PictureBox picControls;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniBack;
    }
}