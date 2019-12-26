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
    public partial class frmCharacter3 : Form
    {
        // declare global variables
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer character3Player;

        public frmCharacter3(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            character3Player = player;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            character3Player.controls.stop();
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // display the main menu form
            new frmMainMenu(ref character3Player, muteForm, level2, level3).Show();
        }

        private void btnPacman_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the first level form with Pacman
            new frmLevelThreeP(ref character3Player, muteForm, level2, level3).Show();
        }

        private void btnMsPacman_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

            // display the first level form with Ms. Pacman
            new frmLevelThreeM(ref character3Player, muteForm, level2, level3).Show();
        }
    }
}
