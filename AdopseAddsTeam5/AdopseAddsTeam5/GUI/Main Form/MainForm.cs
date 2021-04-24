using AdopseAddsTeam5.GUI.Main_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5
{
    public partial class MainForm : Form
    {

        private bool logged = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            watermarkPicbox.Parent = bgImagePicbox;
        }

        private void hideControls()
        {
            searchTableLayout.Hide();
            choicePanel.Hide();
            watermarkPicbox.Hide();
            footerMiddle.Hide();
            leftFooter.Hide();
            rightFooter.Hide();
            sideMenuPanel.Hide();
        }

        private void sideMenuPicbox_Click(object sender, EventArgs e)
        {
            if(logged)
            {
                sideMenuPanel.Visible = !sideMenuPanel.Visible;
            }
            else
            {

            }
        }

        private void controlLogout_Click(object sender, EventArgs e)
        {

        }

        private void controlHomepage_Click(object sender, EventArgs e)
        {

        }

        private void controlProfile_Click(object sender, EventArgs e)
        {
            hideControls();
            profilePanel.Show();
            profilePanel.BringToFront();
            leftFooter.Show();
            rightFooter.Show();
        }

        private void controlFavorites_Click(object sender, EventArgs e)
        {

        }

        private void controlFilters_Click(object sender, EventArgs e)
        {

        }

        private void controlNotifications_Click(object sender, EventArgs e)
        {

        }

        private void controlBuy1_Click(object sender, EventArgs e)
        {

        }

        private void controlRent1_Click(object sender, EventArgs e)
        {

        }

        private void controlAdd1_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void logPicbox_Click(object sender, EventArgs e)
        {

        }

        private void profileNameEdit_Click(object sender, EventArgs e)
        {

        }

        private void profilePicEdit_Click(object sender, EventArgs e)
        {

        }

        private void profileEmailEdit_Click(object sender, EventArgs e)
        {

        }

        private void profileAddListing_Click(object sender, EventArgs e)
        {

        }

        private void controlProfile_Load(object sender, EventArgs e)
        {

        }
    }

}
