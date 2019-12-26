namespace PacmanSasha
{
    partial class frmCharacter3
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
            this.btnMsPacman = new System.Windows.Forms.Button();
            this.btnPacman = new System.Windows.Forms.Button();
            this.picMsPacman = new System.Windows.Forms.PictureBox();
            this.picPacman = new System.Windows.Forms.PictureBox();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBack = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMsPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMsPacman
            // 
            this.btnMsPacman.BackColor = System.Drawing.Color.White;
            this.btnMsPacman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsPacman.Location = new System.Drawing.Point(465, 314);
            this.btnMsPacman.Name = "btnMsPacman";
            this.btnMsPacman.Size = new System.Drawing.Size(126, 37);
            this.btnMsPacman.TabIndex = 10;
            this.btnMsPacman.Text = "Ms. Pacman";
            this.btnMsPacman.UseVisualStyleBackColor = false;
            this.btnMsPacman.Click += new System.EventHandler(this.btnMsPacman_Click);
            // 
            // btnPacman
            // 
            this.btnPacman.BackColor = System.Drawing.Color.White;
            this.btnPacman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacman.Location = new System.Drawing.Point(202, 314);
            this.btnPacman.Name = "btnPacman";
            this.btnPacman.Size = new System.Drawing.Size(94, 37);
            this.btnPacman.TabIndex = 9;
            this.btnPacman.Text = "Pacman";
            this.btnPacman.UseVisualStyleBackColor = false;
            this.btnPacman.Click += new System.EventHandler(this.btnPacman_Click);
            // 
            // picMsPacman
            // 
            this.picMsPacman.Image = global::PacmanSasha.Properties.Resources.Ms2;
            this.picMsPacman.Location = new System.Drawing.Point(475, 162);
            this.picMsPacman.Name = "picMsPacman";
            this.picMsPacman.Size = new System.Drawing.Size(98, 88);
            this.picMsPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMsPacman.TabIndex = 8;
            this.picMsPacman.TabStop = false;
            // 
            // picPacman
            // 
            this.picPacman.Image = global::PacmanSasha.Properties.Resources.Right;
            this.picPacman.Location = new System.Drawing.Point(198, 162);
            this.picPacman.Name = "picPacman";
            this.picPacman.Size = new System.Drawing.Size(98, 88);
            this.picPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacman.TabIndex = 7;
            this.picPacman.TabStop = false;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.ForeColor = System.Drawing.Color.White;
            this.lblCharacter.Location = new System.Drawing.Point(190, 87);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(383, 43);
            this.lblCharacter.TabIndex = 6;
            this.lblCharacter.Text = "Choose Your Character!";
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
            this.mnuOptions.TabIndex = 11;
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
            // frmCharacter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMsPacman);
            this.Controls.Add(this.btnPacman);
            this.Controls.Add(this.picMsPacman);
            this.Controls.Add(this.picPacman);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.mnuOptions);
            this.Name = "frmCharacter3";
            this.Text = "Simple Pacman Game by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picMsPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMsPacman;
        private System.Windows.Forms.Button btnPacman;
        private System.Windows.Forms.PictureBox picMsPacman;
        private System.Windows.Forms.PictureBox picPacman;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniBack;
    }
}