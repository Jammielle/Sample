namespace FIRST_TRIAL
{
    public partial class HomeScreenDisplay : Form
    {
        public HomeScreenDisplay()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StageSelectionScreen stageForm = new StageSelectionScreen();
            stageForm.Show();
            this.Hide();
        }

        private void lblZeroOne_Click(object sender, EventArgs e)
        {

        }

        private void pictureBomb_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
