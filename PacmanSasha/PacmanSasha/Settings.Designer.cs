namespace PacmanSasha
{
    partial class frmSettings
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
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnUnmute = new System.Windows.Forms.Button();
            this.picUnmute = new System.Windows.Forms.PictureBox();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.picPacman1 = new System.Windows.Forms.PictureBox();
            this.picPacman2 = new System.Windows.Forms.PictureBox();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBack = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman2)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.White;
            this.lblSettings.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(307, 36);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(162, 46);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.BackColor = System.Drawing.Color.White;
            this.lblSound.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSound.ForeColor = System.Drawing.Color.Black;
            this.lblSound.Location = new System.Drawing.Point(339, 116);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(89, 36);
            this.lblSound.TabIndex = 2;
            this.lblSound.Text = "Sound";
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.Black;
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Location = new System.Drawing.Point(428, 211);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(98, 39);
            this.btnMute.TabIndex = 3;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnUnmute
            // 
            this.btnUnmute.BackColor = System.Drawing.Color.Black;
            this.btnUnmute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnmute.Location = new System.Drawing.Point(428, 307);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.Size = new System.Drawing.Size(98, 39);
            this.btnUnmute.TabIndex = 4;
            this.btnUnmute.Text = "Unmute";
            this.btnUnmute.UseVisualStyleBackColor = false;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // picUnmute
            // 
            this.picUnmute.Image = global::PacmanSasha.Properties.Resources.Unmute;
            this.picUnmute.Location = new System.Drawing.Point(246, 288);
            this.picUnmute.Name = "picUnmute";
            this.picUnmute.Size = new System.Drawing.Size(110, 80);
            this.picUnmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnmute.TabIndex = 6;
            this.picUnmute.TabStop = false;
            // 
            // picMute
            // 
            this.picMute.Image = global::PacmanSasha.Properties.Resources.Mute;
            this.picMute.Location = new System.Drawing.Point(246, 183);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(110, 80);
            this.picMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMute.TabIndex = 5;
            this.picMute.TabStop = false;
            // 
            // picPacman1
            // 
            this.picPacman1.Image = global::PacmanSasha.Properties.Resources.Settings;
            this.picPacman1.Location = new System.Drawing.Point(12, 36);
            this.picPacman1.Name = "picPacman1";
            this.picPacman1.Size = new System.Drawing.Size(122, 116);
            this.picPacman1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacman1.TabIndex = 0;
            this.picPacman1.TabStop = false;
            // 
            // picPacman2
            // 
            this.picPacman2.Image = global::PacmanSasha.Properties.Resources.Settings;
            this.picPacman2.Location = new System.Drawing.Point(666, 36);
            this.picPacman2.Name = "picPacman2";
            this.picPacman2.Size = new System.Drawing.Size(122, 116);
            this.picPacman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacman2.TabIndex = 7;
            this.picPacman2.TabStop = false;
            // 
            // mnuOptions
            // 
            this.mnuOptions.BackColor = System.Drawing.Color.Black;
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniBack});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(800, 24);
            this.mnuOptions.TabIndex = 8;
            this.mnuOptions.Text = "Options";
            // 
            // mniExit
            // 
            this.mniExit.ForeColor = System.Drawing.Color.White;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(38, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniBack
            // 
            this.mniBack.BackColor = System.Drawing.Color.Black;
            this.mniBack.ForeColor = System.Drawing.Color.White;
            this.mniBack.Name = "mniBack";
            this.mniBack.Size = new System.Drawing.Size(44, 20);
            this.mniBack.Text = "Back";
            this.mniBack.Click += new System.EventHandler(this.mniBack_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPacman2);
            this.Controls.Add(this.picUnmute);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.btnUnmute);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.picPacman1);
            this.Controls.Add(this.mnuOptions);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmSettings";
            this.Text = "Simple Pacman Game by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman2)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPacman1;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnUnmute;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.PictureBox picUnmute;
        private System.Windows.Forms.PictureBox picPacman2;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniBack;
    }
}