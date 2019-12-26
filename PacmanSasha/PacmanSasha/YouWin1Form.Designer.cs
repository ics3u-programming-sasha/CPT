namespace PacmanSasha
{
    partial class frmYouWin1
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
            this.picYouWin = new System.Windows.Forms.PictureBox();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBack = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWin)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // picYouWin
            // 
            this.picYouWin.BackColor = System.Drawing.Color.White;
            this.picYouWin.Image = global::PacmanSasha.Properties.Resources.YouWin;
            this.picYouWin.Location = new System.Drawing.Point(-2, -2);
            this.picYouWin.Name = "picYouWin";
            this.picYouWin.Size = new System.Drawing.Size(803, 456);
            this.picYouWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYouWin.TabIndex = 0;
            this.picYouWin.TabStop = false;
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
            this.mnuOptions.TabIndex = 1;
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
            // frmYouWin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuOptions);
            this.Controls.Add(this.picYouWin);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmYouWin1";
            this.Text = "Simple Pacman Game by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picYouWin)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picYouWin;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniBack;
    }
}