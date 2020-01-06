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
    public partial class frmMainMenu : Form
    {
        // declare global variables
        WMPLib.WindowsMediaPlayer mainPlayer;
        bool level2, level3, muteForm;

        public frmMainMenu(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            mainPlayer = player;

            level2 = true;
            level3 = true;
            
            // if level2 is true
            if (level2 == true)
            {
                // enable the level 2 button
                btnLevel2.Enabled = true;
            }
            else
            {
                // disable the level 2 button
                btnLevel2.Enabled = false;
            }

            // if level3 is true
            if (level3 == true)
            {
                // enable the level 3 button
                btnLevel3.Enabled = true;
            }
            else
            {
                // disable the level 3 button
                btnLevel3.Enabled = false;
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // display the instructions form
            new frmInstructions(ref mainPlayer, muteForm, level2, level3).Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the settings form
            new frmSettings(ref mainPlayer, muteForm, level2, level3).Show();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the character form
            new frmCharacter(ref mainPlayer, muteForm, level2, level3).Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the credits form
            new frmCredits(ref mainPlayer, muteForm, level2, level3).Show();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the second character form
            new frmCharacter2(ref mainPlayer, muteForm, level2, level3).Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // stop the music
            mainPlayer.controls.stop();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the second character form
            new frmCharacter3(ref mainPlayer, muteForm, level2, level3).Show();
        }
    }
}
