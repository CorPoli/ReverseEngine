using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatCracker
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void SRC_Click(object sender, EventArgs e)
        {

            SRC SRCPage = new SRC();
            SRCPage.Show();


            this.Hide();
        }


        private void DOMAINS_Click(object sender, EventArgs e)
        {

            DOMAINS DOMAINSPage = new DOMAINS();
            DOMAINSPage.Show();


            this.Hide();
        }


        private void FLAGS_Click(object sender, EventArgs e)
        {

        }

        private void SUPPORT_Click(object sender, EventArgs e)
        {

            support supportPage = new support();
            supportPage.Show();


            this.Hide();
        }
        
        private void DLLS_Click(object sender, EventArgs e)
        {

        }

        private void Loader_Click(object sender, EventArgs e)
        {

            Loader LoaderPage = new Loader();
            LoaderPage.Show();


            this.Hide();
        }
        
        private void home_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
