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
    public partial class frmGameOver : Form
    {
        // declare global variables
        WMPLib.WindowsMediaPlayer lossPlayer = new WMPLib.WindowsMediaPlayer();
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer overPlayer;

        public frmGameOver(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            overPlayer = player;

            // if muteForm is false
            if (muteForm == false)
            {
                // play the main menu music
                lossPlayer.URL = "GameOver.mp3";
                lossPlayer.controls.play();
            }
            else
            {
                // stop the main menu music
                lossPlayer.controls.stop();
            }
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            lossPlayer.controls.stop();

            // if muteForm is false
            if (muteForm == false)
            {
                // play the main menu music
                overPlayer.controls.play();
            }
            else
            {
                // stop the main menu music
                overPlayer.controls.stop();
            }

            // display the main menu form
            new frmMainMenu(ref overPlayer, muteForm, level2, level3).Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            lossPlayer.controls.stop();
        }
    }
}
