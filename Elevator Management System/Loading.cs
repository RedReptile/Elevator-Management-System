using Lift;
using System;
using System.Windows.Forms;

namespace Elevator_Management_System
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            loadingBar.Interval = 50; 
            loadingBar.Start();
        }

        private void loadingBar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
                percentage.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                loadingBar.Stop(); // Stop the timer to prevent multiple openings
                Form1 elevatorControl = new Form1();
                elevatorControl.Show(); // Opens Form1
                this.Hide(); // Hides the current form
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void percentage_Click(object sender, EventArgs e)
        {

        }
    }
}
