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
    public partial class frmSettings : Form
    {
        // declare global variables
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer settingsPlayer;

        public frmSettings(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            settingsPlayer = player;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            // set mute equal to true
            muteForm = true;
            settingsPlayer.controls.stop();
        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            // set mute equal to false
            muteForm = false;
            settingsPlayer.controls.play();
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // display the main menu form
            new frmMainMenu(ref settingsPlayer, muteForm, level2, level3).Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            settingsPlayer.controls.stop();
        }
    }
}
