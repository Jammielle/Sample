using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FIRST_TRIAL
{
    public partial class StageSelectionScreen : Form
    {
        public StageSelectionScreen()
        {
            InitializeComponent();
        }

        private void btnBackToHomescreen_Click(object sender, EventArgs e)
        {
            HomeScreenDisplay homescreen = new HomeScreenDisplay();
            homescreen.Show();
            this.Hide();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {

        }

        private void btnMediumStage_Click(object sender, EventArgs e)
        {

        }

        private void btnHardStage_Click(object sender, EventArgs e)
        {

        }
    }
}
