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
    public partial class frmYouWin2 : Form
    {
        // declare global variables
        WMPLib.WindowsMediaPlayer winPlayer = new WMPLib.WindowsMediaPlayer();
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer youWin2Player;

        public frmYouWin2(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            youWin2Player = player;

            if (muteForm == false)
            {
                // play the music
                winPlayer.URL = "YouWin.mp3";
                winPlayer.controls.play();
            }
            else
            {
                // stop the music
                winPlayer.controls.stop();
            }

            // set the level2 variable equal to true
            level2 = true;

            // set the level3 variable equal to true
            level3 = true;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the music
            winPlayer.controls.stop();
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
                youWin2Player.controls.play();
            }
            else
            {
                // stop the music
                youWin2Player.controls.stop();
            }

            // display the main menu form
            new frmMainMenu(ref youWin2Player, muteForm, level2, level3).Show();
        }
    }
}
