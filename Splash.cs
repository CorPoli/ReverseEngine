using System;
using System.Windows.Forms;

namespace CheatCracker
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            this.Opacity = 1;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 4750;
            t.Tick += (s, e) =>
            {
                t.Stop();
                this.Close();
            };
            t.Start();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}