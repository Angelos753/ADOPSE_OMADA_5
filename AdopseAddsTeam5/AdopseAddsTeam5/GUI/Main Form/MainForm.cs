using AdopseAddsTeam5.GUI.Main_Form;
using AdopseAddsTeam5.GUI.Custom_Controls;
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
        public static User user1 = new User();

        private static bool logged = false;
        private bool h;
        private bool s = false;
        private string email;

        public MainForm()
        {
            InitializeComponent();
            BindControls();
            DataAccess.AllAdds();
        }

        protected void BindControls()
        {
            resultsSearchbox.DataBindings.Add("Text", searchTextbox, "Text", false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            watermarkPicbox.Parent = bgImagePicbox; 
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {/*
            resultsSearchbox.Text = "Text " + resultsFlowLayout.Controls.GetChildIndex(miniAd1);
            resultsFlowLayout.Controls.SetChildIndex(miniAd2, 0);
            
            if (this.Size.Width < 1290)
            {
                this.resultsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left))));
                //resultsFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            }
            else
            {
                this.resultsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                //resultsFilterPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            footerMiddleB.Hide();
            s = false;
            h = false;
        }

        private void sideMenuPicbox_Click(object sender, EventArgs e)
        {
            sideMenuPanel.BringToFront();
            if(logged)
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

            DataAccess db = new DataAccess();
            Adds[] add = db.FavoriteAdds(user1.EmailAddress);
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
            footerMiddleB.BringToFront();
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
            footerMiddleB.BringToFront();
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

        private void profilePicEdit_Click(object sender, EventArgs e)
        {

        }

        private void profileEmailEdit_Click(object sender, EventArgs e)
        {
            email = profileEmailText.Text;
            if (profileEmailEdit.Text == "Επεξεργασία")
            {
                profileEmailText.Enabled = true;
                profileEmailText.ReadOnly = false;
                profileEmailText.Focus();
                profileEmailEdit.Text = "Αποθήκευση";
            }
            else
            {
                profileEmailText.Enabled = false;
                profileEmailText.ReadOnly = true;
                profileEmailEdit.Text = "Επεξεργασία";
                email = profileEmailText.Text;
            }
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
            new MessageForm().ShowDialog();
        }

        public static void login(User user)
        {
            logged = true;
            user1 = user;
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

        private void add2AddressTextbox_Enter(object sender, EventArgs e)
        {
            if(add2AddressTextbox.Text == "Διεύθυνση")
            {
                add2AddressTextbox.Text = "";
                add2AddressTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void add2AddressTextbox_Leave(object sender, EventArgs e)
        {
            if (add2AddressTextbox.Text == "")
            {
                add2AddressTextbox.Text = "Διεύθυνση";
                add2AddressTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void perioxiTextbox_Enter(object sender, EventArgs e)
        {
            if (perioxiTextbox.Text == "π.χ. Θεσσαλονίκη - Τούμπα")
            {
                perioxiTextbox.Text = "";
                perioxiTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void perioxiTextbox_Leave(object sender, EventArgs e)
        {
            if (perioxiTextbox.Text == "")
            {
                perioxiTextbox.Text = "π.χ. Θεσσαλονίκη - Τούμπα";
                perioxiTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
           
        }

        private void timiTextbox_Enter(object sender, EventArgs e)
        {
            if (timiTextbox.Text == "π.χ. €150000 ή 150.000")
            {
                timiTextbox.Text = "";
                timiTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void timiTextbox_Leave(object sender, EventArgs e)
        {
            if (timiTextbox.Text == "")
            {
                timiTextbox.Text = "π.χ. €150000 ή 150.000";
                timiTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void emvadoTextbox_Enter(object sender, EventArgs e)
        {
            if (emvadoTextbox.Text == "π.χ. 89")
            {
                emvadoTextbox.Text = "";
                emvadoTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void emvadoTextbox_Leave(object sender, EventArgs e)
        {
            if (emvadoTextbox.Text == "")
            {
                emvadoTextbox.Text = "π.χ. 89";
                emvadoTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void tiposTextbox_Enter(object sender, EventArgs e)
        {
            if (tiposTextbox.Text == "π.χ. Διαμέρισμα ή Μονοκατοικία")
            {
                tiposTextbox.Text = "";
                tiposTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void tiposTextbox_Leave(object sender, EventArgs e)
        {
            if (tiposTextbox.Text == "")
            {
                tiposTextbox.Text = "π.χ. Διαμέρισμα ή Μονοκατοικία";
                tiposTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void phoneTextbox_Enter(object sender, EventArgs e)
        {
            if (phoneTextbox.Text == "π.χ. 2101234567 ή 6912345678")
            {
                phoneTextbox.Text = "";
                phoneTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void phoneTextbox_Leave(object sender, EventArgs e)
        {
            if (phoneTextbox.Text == "")
            {
                phoneTextbox.Text = "π.χ. 2101234567 ή 6912345678";
                phoneTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void vlMsgFName_Enter(object sender, EventArgs e)
        {
            if (vlMsgFName.Text == "Όνομα")
            {
                vlMsgFName.Text = "";
                vlMsgFName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void vlMsgFName_Leave(object sender, EventArgs e)
        {
            if (vlMsgFName.Text == "")
            {
                vlMsgFName.Text = "Όνομα";
                vlMsgFName.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void vlMsgLName_Enter(object sender, EventArgs e)
        {
            if (vlMsgLName.Text == "Επώνυμο")
            {
                vlMsgLName.Text = "";
                vlMsgLName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void vlMsgLName_Leave(object sender, EventArgs e)
        {
            if (vlMsgLName.Text == "")
            {
                vlMsgLName.Text = "Επώνυμο";
                vlMsgLName.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void vlMsgPhone_Enter(object sender, EventArgs e)
        {
            if (vlMsgPhone.Text == "Τηλέφωνο")
            {
                vlMsgPhone.Text = "";
                vlMsgPhone.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void vlMsgPhone_Leave(object sender, EventArgs e)
        {
            if (vlMsgPhone.Text == "")
            {
                vlMsgPhone.Text = "Τηλέφωνο";
                vlMsgPhone.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void vlMsgEmail_Enter(object sender, EventArgs e)
        {
            if (vlMsgEmail.Text == "Email")
            {
                vlMsgEmail.Text = "";
                vlMsgEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void vlMsgEmail_Leave(object sender, EventArgs e)
        {
            if (vlMsgEmail.Text == "")
            {
                vlMsgEmail.Text = "Email";
                vlMsgEmail.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void vlMsgText_Enter(object sender, EventArgs e)
        {
            if (vlMsgText.Text == "Το μήνυμα σας...")
            {
                vlMsgText.Text = "";
                vlMsgText.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void vlMsgText_Leave(object sender, EventArgs e)
        {
            if (vlMsgText.Text == "")
            {
                vlMsgText.Text = "Το μήνυμα σας...";
                vlMsgText.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMinTimi_Enter(object sender, EventArgs e)
        {
            if (filterMinTimi.Text == "Ελάχιστη")
            {
                filterMinTimi.Text = "";
                filterMinTimi.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMinTimi_Leave(object sender, EventArgs e)
        {
            if (filterMinTimi.Text == "")
            {
                filterMinTimi.Text = "Ελάχιστη";
                filterMinTimi.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMinEmvado_Enter(object sender, EventArgs e)
        {
            if (filterMinEmvado.Text == "Ελάχιστο")
            {
                filterMinEmvado.Text = "";
                filterMinEmvado.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMinEmvado_Leave(object sender, EventArgs e)
        {
            if (filterMinEmvado.Text == "")
            {
                filterMinEmvado.Text = "Ελάχιστο";
                filterMinEmvado.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMinRooms_Enter(object sender, EventArgs e)
        {
            if (filterMinRooms.Text == "Ελάχιστο")
            {
                filterMinRooms.Text = "";
                filterMinRooms.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMinRooms_Leave(object sender, EventArgs e)
        {
            if (filterMinRooms.Text == "")
            {
                filterMinRooms.Text = "Ελάχιστο";
                filterMinRooms.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMinBaths_Enter(object sender, EventArgs e)
        {
            if (filterMinBaths.Text == "Ελάχιστο")
            {
                filterMinBaths.Text = "";
                filterMinBaths.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMinBaths_Leave(object sender, EventArgs e)
        {
            if (filterMinBaths.Text == "")
            {
                filterMinBaths.Text = "Ελάχιστο";
                filterMinBaths.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMaxTimi_Enter(object sender, EventArgs e)
        {
            if (filterMaxTimi.Text == "Μέγιστη")
            {
                filterMaxTimi.Text = "";
                filterMaxTimi.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMaxTimi_Leave(object sender, EventArgs e)
        {
            if (filterMaxTimi.Text == "")
            {
                filterMaxTimi.Text = "Μέγιστη";
                filterMaxTimi.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMaxEmvado_Enter(object sender, EventArgs e)
        {
            if (filterMaxEmvado.Text == "Μέγιστο")
            {
                filterMaxEmvado.Text = "";
                filterMaxEmvado.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMaxEmvado_Leave(object sender, EventArgs e)
        {
            if (filterMaxEmvado.Text == "")
            {
                filterMaxEmvado.Text = "Μέγιστο";
                filterMaxEmvado.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMaxRooms_Enter(object sender, EventArgs e)
        {
            if (filterMaxRooms.Text == "Μέγιστο")
            {
                filterMaxRooms.Text = "";
                filterMaxRooms.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMaxRooms_Leave(object sender, EventArgs e)
        {
            if (filterMaxRooms.Text == "")
            {
                filterMaxRooms.Text = "Μέγιστο";
                filterMaxRooms.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void filterMaxBaths_Enter(object sender, EventArgs e)
        {
            if (filterMaxBaths.Text == "Μέγιστο")
            {
                filterMaxBaths.Text = "";
                filterMaxBaths.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void filterMaxBaths_Leave(object sender, EventArgs e)
        {
            if (filterMaxBaths.Text == "")
            {
                filterMaxBaths.Text = "Μέγιστο";
                filterMaxBaths.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void searchTextbox_Enter(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Πληκτρολογήστε διεύθυνση, πόλη ή Τ.Κ.")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextbox_Leave(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "")
            {
                searchTextbox.Text = "Πληκτρολογήστε διεύθυνση, πόλη ή Τ.Κ.";
                searchTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void profileEmailText_Leave(object sender, EventArgs e)
        {
            profileEmailText.Text = email;
            profileEmailText.Enabled = false;
            profileEmailText.ReadOnly = true;
            profileEmailEdit.Text = "Επεξεργασία";            
        }

        private void resultsRentBtn_Click(object sender, EventArgs e)
        {
            resultsRentBtn.BackColor = System.Drawing.Color.White;
            resultsRentBtn.ForeColor = System.Drawing.Color.Black;
            resultsBuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(205)))));
        }

        private void resultsBuyBtn_Click(object sender, EventArgs e)
        {
            resultsBuyBtn.BackColor = System.Drawing.Color.White;
            resultsBuyBtn.ForeColor = System.Drawing.Color.Black;
            resultsRentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(205)))));
        }

        private void resultsSearchbox_Enter(object sender, EventArgs e)
        {
            if (resultsSearchbox.Text == "Πληκτρολογήστε διεύθυνση, πόλη ή Τ.Κ.")
            {
                resultsSearchbox.Text = "";
                resultsSearchbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void resultsSearchbox_Leave(object sender, EventArgs e)
        {
            if (resultsSearchbox.Text == "")
            {
                resultsSearchbox.Text = "Πληκτρολογήστε διεύθυνση, πόλη ή Τ.Κ.";
                resultsSearchbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void miniAd1_Click(object sender, EventArgs e)
        {
            int n = 4;
            miniAd m = new miniAd();
            UserFilter u = new UserFilter();
            string t = "listing" + n;
            m.setPrice(t);
            m.Click += (sender1, e1) =>
            {
                viewListing();
            };
            resultsFlowLayout.Controls.Add(m);
        }

        public void viewListing()
        {
            hideControls();
            viewListingPanel.Show();
            viewListingPanel.BringToFront();
        }

        private void vlExit_Click(object sender, EventArgs e)
        {
            viewListingPanel.Hide();
            resultsPanel.Show();
            resultsFilterPanel.Show();
            resultsSearchTableLayout.Show();
        }

        private void controlProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
