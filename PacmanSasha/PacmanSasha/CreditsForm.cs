/*
 * Created by: Sasha Malko
 * Created on: 16-Dec-2019
 * Created for: ICS3U Programming
 * CPT - Simple Pacman Game
 * This program allows the user to play a simple game of Pacman. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanSasha
{
    public partial class frmCredits : Form
    {
        // declare global variables
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer creditsPlayer;

        public frmCredits(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            creditsPlayer = player;

            // hide the label
            lblThanks.Visible = false;
        }

        private void playTimer(object sender, EventArgs e)
        {
            // scroll down the screen
            foreach (Control x in pnlScroll.Controls)
            {
                // move the top of the panel up
                x.Top -= 1;
            }
        }

        // declare the time used by the timer
        public int totalTime { get; set; }

        private void tmrThanks_Tick(object sender, EventArgs e)
        {
            // if the total time is greater than 0
            if (totalTime > 0)
            {
                // subtract one from the total time
                totalTime = totalTime - 1;

                // if the total time is equal to 0
                if (totalTime == 0)
                {
                    // display the label
                    lblThanks.Visible = true;
                }
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            creditsPlayer.controls.stop();
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // display the main menu form
            new frmMainMenu(ref creditsPlayer, muteForm, level2, level3).Show();
        }

        private void frmCredits_Load(object sender, EventArgs e)
        {
            // set the total time equal to 13
            totalTime = 13;

            // start the timer
            tmrThanks.Start();
        }
    }
}
