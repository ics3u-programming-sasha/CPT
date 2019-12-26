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
    public partial class frmYouWin1 : Form
    {
        // declare global variables
        WMPLib.WindowsMediaPlayer winPlayer = new WMPLib.WindowsMediaPlayer();
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer youWin1Player;

        public frmYouWin1(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            youWin1Player = player;

            if (muteForm == false)
            {
                // play the music
                winPlayer.URL = "YouWin.mp3";
                winPlayer.controls.play();
            }
            else
            {
                // stop the music
                winPlayer.controls.play();
            }

            // set the level2 variable equal to true
            level2 = true;

            // set the level3 variable equal to false
            level3 = false;
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            winPlayer.controls.stop();

            if (muteForm == false)
            {
                // start the music
                youWin1Player.controls.play();
            }
            else
            {
                // stop the music
                youWin1Player.controls.stop();
            }

            // display the main menu form
            new frmMainMenu(ref youWin1Player, muteForm, level2, level3).Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            winPlayer.controls.stop();
        }
    }
}
