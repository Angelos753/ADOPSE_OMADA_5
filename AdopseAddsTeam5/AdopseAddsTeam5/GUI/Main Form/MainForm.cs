using AdopseAddsTeam5.GUI.Main_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5
{
    public partial class MainForm : Form
    {

        private static bool logged = false;
        private bool h;
        private bool s = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            watermarkPicbox.Parent = bgImagePicbox;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(s)
            {
                if (this.Size.Width < 1290)
                {
                    resultsFilterPanel.Hide();
                }
                else
                {
                    resultsFilterPanel.Show();
                    resultsFilterPanel.BringToFront();
                }
            }
            
            /*if (choicePanel.Visible != true) 
            {
                if (this.Size.Width < 1218)
                {
                    footerLeft.Hide();
                    footerRight.Hide();
                }
                else
                {
                    footerLeft.Show();
                    footerRight.Show();
                }
            }*/
        }

        private void hideControls()
        {
            sideMenuPanel.Hide();
            searchTableLayout.Hide();
            choicePanel.Hide();
            watermarkPicbox.Hide();
            profilePanel.Hide();
            favoritesPanel.Hide();
            filtersPanel.Hide();
            notificationsPanel.Hide();
            resultsPanel.Hide();
            resultsSearchTableLayout.Hide();
            resultsCombo.Hide();
            resultsFilterPanel.Hide();
            addPanel1.Hide();
            addPanel2.Hide();
            addPanel3.Hide();
            viewListingPanel.Hide();
            footerLeft.Hide();
            footerRight.Hide();
            footerMiddle.Hide();
            s = false;
            h = false;
        }

        private void sideMenuPicbox_Click(object sender, EventArgs e)
        {
            sideMenuPanel.BringToFront();
            if(logged /*&& (this.Size.Width > 1218 || choicePanel.Visible != false)*/)
            {
                sideMenuPanel.Visible = !sideMenuPanel.Visible;
            }
            else
            {
                new AccountForm().ShowDialog();
            }
        }

        private void controlLogout_Click(object sender, EventArgs e)
        {
            logged = false;
            logPicbox.Image = global::AdopseAddsTeam5.Properties.Resources.outline_login_white_24dp;
            sideMenuPanel.Hide();
        }

        private void controlHomepage_Click(object sender, EventArgs e)
        {
            hideControls();
            searchTableLayout.Show();
            searchTableLayout.BringToFront();
            choicePanel.Show();
            footerMiddle.Show();
            watermarkPicbox.Show();
            h = true;
        }

        private void controlProfile_Click(object sender, EventArgs e)
        {
            hideControls();
            profilePanel.Show();
            profilePanel.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void controlFavorites_Click(object sender, EventArgs e)
        {
            hideControls();
            favoritesPanel.Show();
            favoritesPanel.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void controlFilters_Click(object sender, EventArgs e)
        {
            hideControls();
            filtersPanel.Show();
            filtersPanel.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void controlNotifications_Click(object sender, EventArgs e)
        {
            hideControls();
            notificationsPanel.Show();
            notificationsPanel.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void controlBuy1_Click(object sender, EventArgs e)
        {
            hideControls();
            this.showResults();
            footerLeft.Show();
            footerRight.Show();
            footerMiddleB.Show();
            footerMiddleB.BringToFront();
            s = true;
        }

        private void controlRent1_Click(object sender, EventArgs e)
        {
            hideControls();
            this.showResults();
            footerLeft.Show();
            footerRight.Show();
            s = true;
        }

        private void controlAdd1_Click(object sender, EventArgs e)
        {
            hideControls();
            addPanel1.Show();
            addPanel1.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            hideControls();
            showResults();
            footerLeft.Show();
            footerRight.Show();
            s = true;
        }

        private void logPicbox_Click(object sender, EventArgs e)
        {
            if(!logged)
            {
                new AccountForm().ShowDialog();
            }
            else
            {
                logged = false;
                logPicbox.Image = global::AdopseAddsTeam5.Properties.Resources.outline_login_white_24dp;
            }
        }

        private void profileNameEdit_Click(object sender, EventArgs e)
        {
            hideControls();
            viewListingPanel.Show();
            viewListingPanel.BringToFront();
        }

        private void profilePicEdit_Click(object sender, EventArgs e)
        {

        }

        private void profileEmailEdit_Click(object sender, EventArgs e)
        {

        }

        private void profileAddListing_Click(object sender, EventArgs e)
        {
            hideControls();
            addPanel1.Show();
            addPanel1.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void add1Next_Click(object sender, EventArgs e)
        {
            addPanel1.Hide();
            addPanel2.BringToFront();
            addPanel2.Show();
        }

        private void add2Next_Click(object sender, EventArgs e)
        {
            addPanel2.Hide();
            addPanel3.BringToFront();
            addPanel3.Show();
        }

        private PictureBox[] pics = new PictureBox[10];
        private int x = 0;

        private void add3PicAdd_Click(object sender, EventArgs e)
        {
            pics[0] = add3Picbox1;
            add3Dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            add3Dialog.Multiselect = false;
            if (add3Dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = ResizeImage(new Bitmap(add3Dialog.FileName), 90, 90);
                pics[x].Image = b;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void add3Post_Click(object sender, EventArgs e)
        {
            addPanel3.Hide();
            controlHomepage_Click(this, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            messagePanel.Show();
            messagePanel.BringToFront();
        }

        private void messageExit_Click(object sender, EventArgs e)
        {
            messagePanel.Hide();
        }

        public static void login()
        {
            logged = true;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if(logged)
            {
                logPicbox.Image = global::AdopseAddsTeam5.Properties.Resources.outline_logout_white_24dp;
            }
        }

        private void searchFilterSave_Click(object sender, EventArgs e)
        {
            if(logged)
            {
                new FilterSave().ShowDialog();
            }
            else
            {
                new AccountForm().ShowDialog();
            }
        }

        private void vlMsgSend_Click(object sender, EventArgs e)
        {

        }

        private void vlShowPhone_Click(object sender, EventArgs e)
        {
            if(!logged)
            {
                new AccountForm().ShowDialog();
            }
            else
            {
                vlShowPhone.BackColor = System.Drawing.Color.White;
                vlShowPhone.ForeColor = System.Drawing.Color.Black;
                vlShowPhone.Text = "6937123456";
            }
        }

        private void viewListingPic1_Click(object sender, EventArgs e)
        {
            viewListingMainPic.Image = ((PictureBox)sender).Image;
        }

        private void viewListingPic2_Click(object sender, EventArgs e)
        {
            viewListingMainPic.Image = ((PictureBox)sender).Image;
        }

        private void viewListingPic3_Click(object sender, EventArgs e)
        {
            viewListingMainPic.Image = ((PictureBox)sender).Image;
        }

        private void viewListingPic4_Click(object sender, EventArgs e)
        {
            viewListingMainPic.Image = ((PictureBox)sender).Image;
        }

        private void viewListingPic5_Click(object sender, EventArgs e)
        {
            viewListingMainPic.Image = ((PictureBox)sender).Image;
        }

        private void viewListingSave_Click(object sender, EventArgs e)
        {

        }

        private void viewListingPrint_Click(object sender, EventArgs e)
        {

        }

        private void viewListingExit_Click(object sender, EventArgs e)
        {
            viewListingPanel.Hide();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            viewListingPanel.Show();
            viewListingPanel.BringToFront();
        }

        private void showResults()
        {
            resultsPanel.Show();
            resultsPanel.BringToFront();
            resultsCombo.Show();
            resultsCombo.BringToFront();
            resultsSearchTableLayout.Show();
            resultsSearchTableLayout.BringToFront();
            if (this.Size.Width >= 1290)
            {
                resultsFilterPanel.Show();
                resultsFilterPanel.BringToFront();
            }
                
        }
    }

}
