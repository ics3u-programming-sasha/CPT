namespace PacmanSasha
{
    partial class frmCredits
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
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.lblLink18 = new System.Windows.Forms.Label();
            this.lblLink17 = new System.Windows.Forms.Label();
            this.lblLink16 = new System.Windows.Forms.Label();
            this.lblLink15 = new System.Windows.Forms.Label();
            this.lblLink14 = new System.Windows.Forms.Label();
            this.lblLink13 = new System.Windows.Forms.Label();
            this.lblSounds = new System.Windows.Forms.Label();
            this.lblLink12 = new System.Windows.Forms.Label();
            this.lblLink11 = new System.Windows.Forms.Label();
            this.lblLink10 = new System.Windows.Forms.Label();
            this.lblLink9 = new System.Windows.Forms.Label();
            this.lblLink8 = new System.Windows.Forms.Label();
            this.lblLink7 = new System.Windows.Forms.Label();
            this.lblLink6 = new System.Windows.Forms.Label();
            this.lblLink5 = new System.Windows.Forms.Label();
            this.lblLink4 = new System.Windows.Forms.Label();
            this.lblLink3 = new System.Windows.Forms.Label();
            this.lblLink2 = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.lblImages = new System.Windows.Forms.Label();
            this.lblLink1 = new System.Windows.Forms.Label();
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.tmrThanks = new System.Windows.Forms.Timer(this.components);
            this.mnuOptions.SuspendLayout();
            this.pnlScroll.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuOptions.TabIndex = 0;
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
            // tmrScroll
            // 
            this.tmrScroll.Enabled = true;
            this.tmrScroll.Interval = 20;
            this.tmrScroll.Tick += new System.EventHandler(this.playTimer);
            // 
            // pnlScroll
            // 
            this.pnlScroll.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlScroll.Controls.Add(this.lblLink18);
            this.pnlScroll.Controls.Add(this.lblLink17);
            this.pnlScroll.Controls.Add(this.lblLink16);
            this.pnlScroll.Controls.Add(this.lblLink15);
            this.pnlScroll.Controls.Add(this.lblLink14);
            this.pnlScroll.Controls.Add(this.lblLink13);
            this.pnlScroll.Controls.Add(this.lblSounds);
            this.pnlScroll.Controls.Add(this.lblLink12);
            this.pnlScroll.Controls.Add(this.lblLink11);
            this.pnlScroll.Controls.Add(this.lblLink10);
            this.pnlScroll.Controls.Add(this.lblLink9);
            this.pnlScroll.Controls.Add(this.lblLink8);
            this.pnlScroll.Controls.Add(this.lblLink7);
            this.pnlScroll.Controls.Add(this.lblLink6);
            this.pnlScroll.Controls.Add(this.lblLink5);
            this.pnlScroll.Controls.Add(this.lblLink4);
            this.pnlScroll.Controls.Add(this.lblLink3);
            this.pnlScroll.Controls.Add(this.lblLink2);
            this.pnlScroll.Controls.Add(this.lblTutorial);
            this.pnlScroll.Controls.Add(this.lblImages);
            this.pnlScroll.Controls.Add(this.lblLink1);
            this.pnlScroll.Controls.Add(this.lblProgrammer);
            this.pnlScroll.Controls.Add(this.lblCredits);
            this.pnlScroll.Location = new System.Drawing.Point(0, 12);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(800, 400);
            this.pnlScroll.TabIndex = 1;
            // 
            // lblLink18
            // 
            this.lblLink18.AutoSize = true;
            this.lblLink18.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink18.ForeColor = System.Drawing.Color.White;
            this.lblLink18.Location = new System.Drawing.Point(356, 382);
            this.lblLink18.Name = "lblLink18";
            this.lblLink18.Size = new System.Drawing.Size(332, 16);
            this.lblLink18.TabIndex = 23;
            this.lblLink18.Text = "https://www.youtube.com/watch?v=GGoYBJvPEdY";
            // 
            // lblLink17
            // 
            this.lblLink17.AutoSize = true;
            this.lblLink17.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink17.ForeColor = System.Drawing.Color.White;
            this.lblLink17.Location = new System.Drawing.Point(356, 366);
            this.lblLink17.Name = "lblLink17";
            this.lblLink17.Size = new System.Drawing.Size(334, 16);
            this.lblLink17.TabIndex = 22;
            this.lblLink17.Text = "https://www.youtube.com/watch?v=5CsyGe4F8CQ";
            // 
            // lblLink16
            // 
            this.lblLink16.AutoSize = true;
            this.lblLink16.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink16.ForeColor = System.Drawing.Color.White;
            this.lblLink16.Location = new System.Drawing.Point(356, 350);
            this.lblLink16.Name = "lblLink16";
            this.lblLink16.Size = new System.Drawing.Size(325, 16);
            this.lblLink16.TabIndex = 21;
            this.lblLink16.Text = "https://www.youtube.com/watch?v=aOllPj3B6K4";
            // 
            // lblLink15
            // 
            this.lblLink15.AutoSize = true;
            this.lblLink15.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink15.ForeColor = System.Drawing.Color.White;
            this.lblLink15.Location = new System.Drawing.Point(12, 382);
            this.lblLink15.Name = "lblLink15";
            this.lblLink15.Size = new System.Drawing.Size(325, 16);
            this.lblLink15.TabIndex = 20;
            this.lblLink15.Text = "https://www.youtube.com/watch?v=lIx8TrlSV7I";
            // 
            // lblLink14
            // 
            this.lblLink14.AutoSize = true;
            this.lblLink14.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink14.ForeColor = System.Drawing.Color.White;
            this.lblLink14.Location = new System.Drawing.Point(13, 366);
            this.lblLink14.Name = "lblLink14";
            this.lblLink14.Size = new System.Drawing.Size(331, 16);
            this.lblLink14.TabIndex = 19;
            this.lblLink14.Text = "https://www.youtube.com/watch?v=KL_FkWrFThA";
            // 
            // lblLink13
            // 
            this.lblLink13.AutoSize = true;
            this.lblLink13.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink13.ForeColor = System.Drawing.Color.White;
            this.lblLink13.Location = new System.Drawing.Point(12, 350);
            this.lblLink13.Name = "lblLink13";
            this.lblLink13.Size = new System.Drawing.Size(316, 16);
            this.lblLink13.TabIndex = 18;
            this.lblLink13.Text = "https://www.youtube.com/watch?v=BxYzjjs6d1s";
            // 
            // lblSounds
            // 
            this.lblSounds.AutoSize = true;
            this.lblSounds.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSounds.ForeColor = System.Drawing.Color.White;
            this.lblSounds.Location = new System.Drawing.Point(16, 327);
            this.lblSounds.Name = "lblSounds";
            this.lblSounds.Size = new System.Drawing.Size(122, 23);
            this.lblSounds.TabIndex = 17;
            this.lblSounds.Text = "Sounds Used:";
            // 
            // lblLink12
            // 
            this.lblLink12.AutoSize = true;
            this.lblLink12.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink12.ForeColor = System.Drawing.Color.White;
            this.lblLink12.Location = new System.Drawing.Point(13, 311);
            this.lblLink12.Name = "lblLink12";
            this.lblLink12.Size = new System.Drawing.Size(785, 16);
            this.lblLink12.TabIndex = 16;
            this.lblLink12.Text = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwgyynSaS_rj1BNjhCOz5ZdpTek" +
    "0Y6rVnbAB8UP0uWgozVfkc1&s";
            // 
            // lblLink11
            // 
            this.lblLink11.AutoSize = true;
            this.lblLink11.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink11.ForeColor = System.Drawing.Color.White;
            this.lblLink11.Location = new System.Drawing.Point(13, 296);
            this.lblLink11.Name = "lblLink11";
            this.lblLink11.Size = new System.Drawing.Size(387, 16);
            this.lblLink11.TabIndex = 15;
            this.lblLink11.Text = "https://media.giphy.com/media/A8NkSPltT13H2/giphy.gif";
            // 
            // lblLink10
            // 
            this.lblLink10.AutoSize = true;
            this.lblLink10.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink10.ForeColor = System.Drawing.Color.White;
            this.lblLink10.Location = new System.Drawing.Point(13, 280);
            this.lblLink10.Name = "lblLink10";
            this.lblLink10.Size = new System.Drawing.Size(495, 16);
            this.lblLink10.TabIndex = 13;
            this.lblLink10.Text = "https://www.classicgaming.cc/classics/pac-man/images/character-clyde.png";
            // 
            // lblLink9
            // 
            this.lblLink9.AutoSize = true;
            this.lblLink9.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink9.ForeColor = System.Drawing.Color.White;
            this.lblLink9.Location = new System.Drawing.Point(13, 264);
            this.lblLink9.Name = "lblLink9";
            this.lblLink9.Size = new System.Drawing.Size(489, 16);
            this.lblLink9.TabIndex = 12;
            this.lblLink9.Text = "https://www.classicgaming.cc/classics/pac-man/images/character-inky.png";
            // 
            // lblLink8
            // 
            this.lblLink8.AutoSize = true;
            this.lblLink8.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink8.ForeColor = System.Drawing.Color.White;
            this.lblLink8.Location = new System.Drawing.Point(13, 248);
            this.lblLink8.Name = "lblLink8";
            this.lblLink8.Size = new System.Drawing.Size(497, 16);
            this.lblLink8.TabIndex = 11;
            this.lblLink8.Text = "https://www.classicgaming.cc/classics/pac-man/images/character-pinky.png";
            // 
            // lblLink7
            // 
            this.lblLink7.AutoSize = true;
            this.lblLink7.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink7.ForeColor = System.Drawing.Color.White;
            this.lblLink7.Location = new System.Drawing.Point(12, 232);
            this.lblLink7.Name = "lblLink7";
            this.lblLink7.Size = new System.Drawing.Size(501, 16);
            this.lblLink7.TabIndex = 10;
            this.lblLink7.Text = "https://www.classicgaming.cc/classics/pac-man/images/character-blinky.png";
            // 
            // lblLink6
            // 
            this.lblLink6.AutoSize = true;
            this.lblLink6.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink6.ForeColor = System.Drawing.Color.White;
            this.lblLink6.Location = new System.Drawing.Point(13, 200);
            this.lblLink6.Name = "lblLink6";
            this.lblLink6.Size = new System.Drawing.Size(558, 32);
            this.lblLink6.TabIndex = 9;
            this.lblLink6.Text = "https://images2.minutemediacdn.com/image/upload/c_fill,g_auto,h_1248,w_2220/f_\r\na" +
    "uto,q_auto,w_1100/v1555443906/shape/mentalfloss/5798457948.png";
            // 
            // lblLink5
            // 
            this.lblLink5.AutoSize = true;
            this.lblLink5.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink5.ForeColor = System.Drawing.Color.White;
            this.lblLink5.Location = new System.Drawing.Point(13, 184);
            this.lblLink5.Name = "lblLink5";
            this.lblLink5.Size = new System.Drawing.Size(529, 16);
            this.lblLink5.TabIndex = 8;
            this.lblLink5.Text = "https://i.gifer.com/origin/64/649852e53b7e4edf15ea1c2f23a61f29_w200.gif";
            // 
            // lblLink4
            // 
            this.lblLink4.AutoSize = true;
            this.lblLink4.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink4.ForeColor = System.Drawing.Color.White;
            this.lblLink4.Location = new System.Drawing.Point(13, 168);
            this.lblLink4.Name = "lblLink4";
            this.lblLink4.Size = new System.Drawing.Size(464, 16);
            this.lblLink4.TabIndex = 7;
            this.lblLink4.Text = "https://ak5.picdn.net/shutterstock/videos/1015733875/thumb/10.jpg";
            // 
            // lblLink3
            // 
            this.lblLink3.AutoSize = true;
            this.lblLink3.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink3.ForeColor = System.Drawing.Color.White;
            this.lblLink3.Location = new System.Drawing.Point(12, 152);
            this.lblLink3.Name = "lblLink3";
            this.lblLink3.Size = new System.Drawing.Size(727, 16);
            this.lblLink3.TabIndex = 6;
            this.lblLink3.Text = "https://www.classicgaming.cc/classics/pac-man/images/wallpaper/wallpaper-pacman-l" +
    "ight-trail-1920x1080.jpg";
            // 
            // lblLink2
            // 
            this.lblLink2.AutoSize = true;
            this.lblLink2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink2.ForeColor = System.Drawing.Color.White;
            this.lblLink2.Location = new System.Drawing.Point(12, 132);
            this.lblLink2.Name = "lblLink2";
            this.lblLink2.Size = new System.Drawing.Size(513, 16);
            this.lblLink2.TabIndex = 5;
            this.lblLink2.Text = "https://www.classicgaming.cc/classics/pac-man/images/web/web-paclights.gif";
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.ForeColor = System.Drawing.Color.White;
            this.lblTutorial.Location = new System.Drawing.Point(13, 62);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(136, 23);
            this.lblTutorial.TabIndex = 4;
            this.lblTutorial.Text = "Tutorial Used:";
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImages.ForeColor = System.Drawing.Color.White;
            this.lblImages.Location = new System.Drawing.Point(16, 105);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(133, 23);
            this.lblImages.TabIndex = 3;
            this.lblImages.Text = "Images Used:";
            // 
            // lblLink1
            // 
            this.lblLink1.AutoSize = true;
            this.lblLink1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink1.ForeColor = System.Drawing.Color.White;
            this.lblLink1.Location = new System.Drawing.Point(13, 85);
            this.lblLink1.Name = "lblLink1";
            this.lblLink1.Size = new System.Drawing.Size(636, 20);
            this.lblLink1.TabIndex = 2;
            this.lblLink1.Text = "https://www.mooict.com/c-tutorial-create-a-simple-pac-man-game-in-visual-studio/";
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammer.ForeColor = System.Drawing.Color.White;
            this.lblProgrammer.Location = new System.Drawing.Point(13, 27);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(185, 23);
            this.lblProgrammer.TabIndex = 1;
            this.lblProgrammer.Text = "Programmer: Sasha";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.White;
            this.lblCredits.Location = new System.Drawing.Point(322, 27);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(133, 43);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits";
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.White;
            this.lblThanks.Location = new System.Drawing.Point(305, 418);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(182, 23);
            this.lblThanks.TabIndex = 2;
            this.lblThanks.Text = "Thanks for playing!";
            // 
            // tmrThanks
            // 
            this.tmrThanks.Interval = 1000;
            this.tmrThanks.Tick += new System.EventHandler(this.tmrThanks_Tick);
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.mnuOptions);
            this.Controls.Add(this.pnlScroll);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmCredits";
            this.Text = "Simple Pacman Game by Sasha";
            this.Load += new System.EventHandler(this.frmCredits_Load);
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniBack;
        private System.Windows.Forms.Timer tmrScroll;
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblLink1;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Label lblLink10;
        private System.Windows.Forms.Label lblLink9;
        private System.Windows.Forms.Label lblLink8;
        private System.Windows.Forms.Label lblLink7;
        private System.Windows.Forms.Label lblLink6;
        private System.Windows.Forms.Label lblLink5;
        private System.Windows.Forms.Label lblLink4;
        private System.Windows.Forms.Label lblLink3;
        private System.Windows.Forms.Label lblLink2;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.Label lblLink12;
        private System.Windows.Forms.Label lblLink11;
        private System.Windows.Forms.Label lblLink18;
        private System.Windows.Forms.Label lblLink17;
        private System.Windows.Forms.Label lblLink16;
        private System.Windows.Forms.Label lblLink15;
        private System.Windows.Forms.Label lblLink14;
        private System.Windows.Forms.Label lblLink13;
        private System.Windows.Forms.Label lblSounds;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Timer tmrThanks;
    }
}