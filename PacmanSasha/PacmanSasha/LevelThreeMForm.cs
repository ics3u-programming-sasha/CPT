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
    public partial class frmLevelThreeM : Form
    {
        // declare global variables
        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;
        int speed = 8;
        int ghost1 = 5;
        int ghost2 = 5;
        int ghost3x = 2;
        int ghost3y = 2;
        int ghost4 = 6;
        int score = 0;
        int lives = 3;
        bool level2, level3, muteForm;
        WMPLib.WindowsMediaPlayer introPlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer backPlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer coinPlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer lifePlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer level3MPlayer;

        public frmLevelThreeM(ref WMPLib.WindowsMediaPlayer player, bool mute, bool levelTwo, bool levelThree)
        {
            InitializeComponent();

            // set variables equal to parameters
            level2 = levelTwo;
            level3 = levelThree;
            muteForm = mute;
            level3MPlayer = player;

            // set the total time equal to four
            totalTime = 4;

            // set the time left equal to 200
            timeLeft = 200;

            // start the go timer
            tmrGo.Start();

            // stop the timers
            tmrPlay.Stop();
            tmrCountDown.Stop();

            // hide the go label
            this.lblGo.Visible = false;

            // stop the music
            level3MPlayer.controls.stop();

            // if muteForm is false
            if (muteForm == false)
            {
                // play the introduction music
                introPlayer.URL = "Introduction.mp3";
                introPlayer.controls.play();
            }
            else
            {
                // stop the introduction music
                introPlayer.controls.stop();
            }
        }

        // declare the total time used by the timer
        public int totalTime { get; set; }

        // declare the time left used by the timer
        public int timeLeft { get; set; }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the sounds 
            introPlayer.controls.stop();
            backPlayer.controls.stop();
            coinPlayer.controls.stop();
            lifePlayer.controls.stop();
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the sounds 
            introPlayer.controls.stop();
            backPlayer.controls.stop();
            coinPlayer.controls.stop();

            // if muteForm is false
            if (muteForm == false)
            {
                // play the main menu music
                level3MPlayer.controls.play();
            }
            else
            {
                // stop the main menu music
                level3MPlayer.controls.stop();
            }

            // display the main menu form
            new frmMainMenu(ref level3MPlayer, muteForm, level2, level3).Show();
        }

        private void mniPause_Click(object sender, EventArgs e)
        {
            // stop the timers
            tmrPlay.Stop();
            tmrCountDown.Stop();

            // stop the music
            backPlayer.controls.stop();
        }

        private void mniResume_Click(object sender, EventArgs e)
        {
            // if muteForm is false
            if (muteForm == false)
            {
                // play the background music
                backPlayer.controls.play();
            }
            else
            {
                // stop the background music
                backPlayer.controls.stop();
            }

            // resume the timers
            tmrPlay.Start();
            tmrCountDown.Start();
        }

        private void mniRestart_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            // stop the sound
            introPlayer.controls.stop();
            coinPlayer.controls.stop();
            backPlayer.controls.stop();
            lifePlayer.controls.stop();

            // display the level one with Ms. Pacman form
            new frmLevelThreeM(ref level3MPlayer, muteForm, level2, level3).Show();
        }

        private void tmrGo_Tick(object sender, EventArgs e)
        {
            // if the total time is greater than 0 
            if (totalTime > 0)
            {
                // subtract one from the total time
                totalTime = totalTime - 1;

                // if the total time is equal to 0
                if (totalTime == 0)
                {
                    // hide the start label
                    this.lblStart.Visible = false;

                    // display the go label
                    this.lblGo.Visible = true;
                }
            }
            else
            {
                // stop the timer
                tmrGo.Stop();

                // hide the start label
                lblStart.Visible = false;

                // hide the go label
                lblGo.Visible = false;

                // start the timers
                tmrPlay.Start();
                tmrCountDown.Start();

                // stop the introduction music
                introPlayer.controls.stop();

                // if muteForm is false
                if (muteForm == false)
                {
                    // play the background music
                    backPlayer.URL = "BackgroundSound.mp3";
                    backPlayer.controls.play();
                }
                else
                {
                    // stop the background music
                    backPlayer.controls.stop();
                }
            }
        }

        private void tmrPlay_Tick(object sender, EventArgs e)
        {
            // if goLeft is occurring 
            if (goLeft)
            {
                // let the character travel left
                picMsPacman.Left -= speed;
            }

            // if goRight is occurring 
            if (goRight)
            {
                // let the character travel right
                picMsPacman.Left += speed;
            }

            // if goUp is occurring 
            if (goUp)
            {
                // let the character travel up
                picMsPacman.Top -= speed;
            }

            // if goDown is occurring 
            if (goDown)
            {
                // let the character travel down
                picMsPacman.Top += speed;
            }

            // set the directions and speeds the ghosts travel
            picRedGhost.Left += ghost1;
            picYellowGhost.Left += ghost2;
            picBlueGhost.Top += ghost4;

            // if the red ghost insersects with the wall1 image
            if (picRedGhost.Bounds.IntersectsWith(picWall1.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost1 = -ghost1;
            }

            // if the red ghost insersects with the wall3 image
            else if (picRedGhost.Bounds.IntersectsWith(picWall3.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost1 = -ghost1;
            }

            // if the yellow ghost insersects with the wall1 image
            if (picYellowGhost.Bounds.IntersectsWith(picWall1.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost2 = -ghost2;
            }

            // if the yellow ghost insersects with the wall3 image
            else if (picYellowGhost.Bounds.IntersectsWith(picWall14.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost2 = -ghost2;
            }

            // if the blue ghost insersects with the wall2 image
            if (picBlueGhost.Bounds.IntersectsWith(picWall2.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost4 = -ghost4;
            }

            // if the blue ghost insersects with the wall4 image
            else if (picBlueGhost.Bounds.IntersectsWith(picWall4.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost4 = -ghost4;
            }

            // for every object in the form
            foreach (Control x in this.Controls)
            {
                // if the object is a ghost
                if (x is PictureBox && x.Tag == "ghost")
                {
                    // if the character intersects with a ghost
                    if (((PictureBox)x).Bounds.IntersectsWith(picMsPacman.Bounds))
                    {
                        // if muteForm is false
                        if (muteForm == false)
                        {
                            // play the life lost music
                            lifePlayer.URL = "LifeLost.mp3";
                            lifePlayer.controls.play();
                        }
                        else
                        {
                            // stop the life lost music
                            lifePlayer.controls.stop();
                        }

                        // subtract one life
                        lives = lives - 1;

                        // if the lives left is 2
                        if (lives == 2)
                        {
                            // hide the life 3 image
                            picLife3.Visible = false;

                            // place the character back at the starting location
                            picMsPacman.Left = 33;
                            picMsPacman.Top = 55;
                        }

                        // if the lives left is 1
                        else if (lives == 1)
                        {
                            // hide the life 2 image
                            picLife2.Visible = false;

                            // place the character back at the starting location
                            picMsPacman.Left = 33;
                            picMsPacman.Top = 55;
                        }

                        // if the lives left is 0
                        else if (lives == 0)
                        {
                            // hide the life 1 image
                            picLife1.Visible = false;

                            // place the character back at the starting location
                            picMsPacman.Left = 33;
                            picMsPacman.Top = 55;
                        }

                        // place the red ghost back at the starting location
                        picRedGhost.Left = 472;
                        picRedGhost.Top = 47;
                    }
                }

                // if the object is a coin
                if (x is PictureBox && x.Tag == "coin")
                {
                    // if the character intersects with a coin
                    if (((PictureBox)x).Bounds.IntersectsWith(picMsPacman.Bounds))
                    {
                        // remove the coin from the screen
                        this.Controls.Remove(x);

                        // add one to the total points
                        score++;

                        // display the total points
                        this.lblScore.Text = "Score: " + score;

                        // if muteForm is false
                        if (muteForm == false)
                        {
                            // play the coin music
                            coinPlayer.URL = "Coin.mp3";
                            coinPlayer.controls.play();
                        }
                        else
                        {
                            // stop the coin music
                            coinPlayer.controls.stop();
                        }
                    }
                }

                // if the object is a wall
                if (x is PictureBox && x.Tag == "wall")
                {
                    // if the character intersects with a wall
                    if (((PictureBox)x).Bounds.IntersectsWith(picMsPacman.Bounds))
                    {
                        // place the character back at the starting location
                        picMsPacman.Left = 33;
                        picMsPacman.Top = 55;
                    }
                }
            }

            // if the score is equal to 50
            if (score == 50)
            {
                // close the form
                this.Close();

                // stop the sounds
                backPlayer.controls.stop();
                coinPlayer.controls.stop();
                lifePlayer.controls.stop();

                // display the you win form
                new frmYouWin2(ref level3MPlayer, muteForm, level2, level3).Show();
            }

            // if the lives left is equal to 0
            if (lives == 0)
            {
                // close the form
                this.Close();

                // stop the sounds
                backPlayer.controls.stop();
                coinPlayer.controls.stop();
                lifePlayer.controls.stop();

                // display the game over form
                new frmGameOver(ref level3MPlayer, muteForm, level2, level3).Show();
            }

            // set the direction and speed the ghost travels
            picPinkGhost.Left += ghost3x;
            picPinkGhost.Top += ghost3y;

            // if the pink ghost insersects with the wall8 image
            if (picPinkGhost.Bounds.IntersectsWith(picWall8.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost3x = -ghost3x;
                ghost3y = -ghost3y;
            }

            // if the pink ghost insersects with the wall9 image
            else if (picPinkGhost.Bounds.IntersectsWith(picWall9.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost3x = -ghost3x;
                ghost3y = -ghost3y;
            }

            // if the pink ghost insersects with the wall10 image
            else if (picPinkGhost.Bounds.IntersectsWith(picWall10.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost3x = -ghost3x;
                ghost3y = -ghost3y;
            }

            // if the pink ghost insersects with the wall11 image
            else if (picPinkGhost.Bounds.IntersectsWith(picWall11.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost3x = -ghost3x;
                ghost3y = -ghost3y;
            }

            // if the pink ghost insersects with the wall12 image
            else if (picPinkGhost.Bounds.IntersectsWith(picWall12.Bounds))
            {
                // the ghost will travel in the opposite direction
                ghost3x = -ghost3x;
                ghost3y = -ghost3y;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                // set goLeft equal to true
                goLeft = true;

                // display the left Ms. Pacman image
                picMsPacman.Image = Properties.Resources.MsLeft;
            }

            // if the key pressed is right
            if (e.KeyCode == Keys.Right)
            {
                // set goRight equal to true
                goRight = true;

                // display the right Ms. Pacman image
                picMsPacman.Image = Properties.Resources.MsRight;
            }

            // if the key pressed is up
            if (e.KeyCode == Keys.Up)
            {
                // set goUp equal to true
                goUp = true;

                // display the up Ms. Pacman image
                picMsPacman.Image = Properties.Resources.MsUp;
            }

            // if the key pressed is down
            if (e.KeyCode == Keys.Down)
            {
                // set goDown equal to true
                goDown = true;

                // display the down Ms. Pacman image
                picMsPacman.Image = Properties.Resources.MsDown;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // if the key pressed is left
            if (e.KeyCode == Keys.Left)
            {
                // set goLeft equal to false
                goLeft = false;
            }

            // if the key pressed is right
            if (e.KeyCode == Keys.Right)
            {
                // set goRight equal to false
                goRight = false;
            }

            // if the key pressed is up
            if (e.KeyCode == Keys.Up)
            {
                // set goUp equal to false
                goUp = false;
            }

            // if the key pressed is down
            if (e.KeyCode == Keys.Down)
            {
                // set goDown equal to false
                goDown = false;
            }
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            // if the time left is greater than 0
            if (timeLeft > 0)
            {
                // subtract one from the time left
                timeLeft = timeLeft - 1;

                // display the time left
                lblTimer.Text = "Time Left: " + timeLeft + "s";
            }
            else
            {
                // stop the timers
                tmrCountDown.Stop();
                tmrPlay.Stop();
                tmrGo.Stop();

                // close the form
                this.Close();

                // stop the sounds
                backPlayer.controls.stop();
                coinPlayer.controls.stop();
                lifePlayer.controls.stop();

                // display the game over form
                new frmGameOver(ref level3MPlayer, muteForm, level2, level3).Show();
            }
        }
    }
}
