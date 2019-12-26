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
    public partial class frmSplashScreen : Form
    {
        // declare global variables
        WMPLib.WindowsMediaPlayer splashPlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        bool levelTwo, levelThree, mute;

        public frmSplashScreen()
        {
            InitializeComponent();

            // set the variables equal to false
            levelTwo = false;
            levelThree = false;
            mute = false;

            // play the music
            splashPlayer.URL = "SplashScreen.mp3";
            splashPlayer.controls.play();
        }


        // declare the time used by the timer
        public int totalTime { get; set; }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            // set the total time equal to 36
            totalTime = 36;

            // start the timer
            tmrSwitch.Start();
        }

        private void tmrSwitch_Tick(object sender, EventArgs e)
        {
            // if the total time is greater than 0
            if (totalTime > 0)
            {
                // subtract one from the total time
                totalTime = totalTime - 1;
            }
            else
            {
                // stop the timer
                tmrSwitch.Stop();

                // hide the form
                this.Hide();

                // stop the music
                splashPlayer.controls.stop();

                // play the music
                player.URL = "Music.mp3";
                player.controls.play();

                // display the main menu form
                new frmMainMenu(ref player, mute, levelTwo, levelThree).Show();
            }
        }
    }
}
