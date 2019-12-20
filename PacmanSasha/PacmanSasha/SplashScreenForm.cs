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
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            totalTime = 20;
            timer1.Start();
        }

        public int totalTime { get; set; }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (totalTime > 0)
            {
                totalTime = totalTime - 1;
            }
            else
            {
                timer1.Stop();
                new MainMenuForm().Show();
                this.Hide();
            }
        }
    }
}
