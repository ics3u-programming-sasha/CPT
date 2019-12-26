namespace PacmanSasha
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblLoading = new System.Windows.Forms.Label();
            this.tmrSwitch = new System.Windows.Forms.Timer(this.components);
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.picPacGhosts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacGhosts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Black;
            this.lblLoading.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoading.Location = new System.Drawing.Point(344, 382);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(164, 46);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading...";
            // 
            // tmrSwitch
            // 
            this.tmrSwitch.Tick += new System.EventHandler(this.tmrSwitch_Tick);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::PacmanSasha.Properties.Resources.Loading;
            this.picLoading.Location = new System.Drawing.Point(279, 372);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(59, 56);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 2;
            this.picLoading.TabStop = false;
            // 
            // picPacGhosts
            // 
            this.picPacGhosts.Image = global::PacmanSasha.Properties.Resources.SplashScreen;
            this.picPacGhosts.Location = new System.Drawing.Point(-22, 38);
            this.picPacGhosts.Name = "picPacGhosts";
            this.picPacGhosts.Size = new System.Drawing.Size(819, 352);
            this.picPacGhosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacGhosts.TabIndex = 0;
            this.picPacGhosts.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.picPacGhosts);
            this.Name = "frmSplashScreen";
            this.Text = "Simple Pacman Game by Sasha";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacGhosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPacGhosts;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer tmrSwitch;
		private System.Windows.Forms.PictureBox picLoading;
	}
}

