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
using System.Threading;

namespace AdopseAddsTeam5
{
    public partial class MainForm : Form
    {

        public static User user1 = new User();
        public static Adds newuseradd = new Adds();
        public static GUI.Main_Form.Message[] msg;
        private static bool flag = false;
        private static bool logged = false;
        private string email;
        private string name;
        private PictureBox[] pics = new PictureBox[5];
        private int x = 0;
        private List<WebBrowser> wb = new List<WebBrowser>();

        public MainForm()
        {
            InitializeComponent();
            DataAccess.AllAdds();
            addBrowsers();
    }

        private void MainForm_Load(object sender, EventArgs e)
        {
            watermarkPicbox.Parent = bgImagePicbox; 
        }

        private void addBrowsers()
        {
            wb.Add(vl0);
            wb.Add(vl1);
            wb.Add(vl2);
            wb.Add(vl3);
            wb.Add(vl4);
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
            profileFlowLayout.Controls.Clear();
            resultsFlowLayout.Controls.Clear();
            filtersFlowLayout.Controls.Clear();
            favoritesFlowLayout.Controls.Clear();
            notificationsFlowLayout.Controls.Clear();
            controlHomepage_Click(this, e);
        }

        private void controlHomepage_Click(object sender, EventArgs e)
        {
            hideControls();
            searchTableLayout.Show();
            searchTableLayout.BringToFront();
            choicePanel.Show();
            footerMiddle.Show();
            watermarkPicbox.Show();
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

        private void controlBuy_Click(object sender, EventArgs e)
        {
            hideControls();
            this.showResults();
            footerLeft.Show();
            footerRight.Show();
            footerMiddleB.Show();
            footerMiddleB.BringToFront();
        }

        private void controlRent_Click(object sender, EventArgs e)
        {
            hideControls();
            this.showResults();
            footerLeft.Show();
            footerRight.Show();
            footerMiddleB.BringToFront();
        }

        private void controlAdd_Click(object sender, EventArgs e)
        {
            hideControls();
            addPanel1.Show();
            addPanel1.BringToFront();
            footerLeft.Show();
            footerRight.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            resultsFlowLayout.Controls.Clear();
            List<Adds> a = LuceneSearch.Search(searchTextbox.Text).ToList();
            for(int i=0; i<a.Count; i++)
            {
                miniAd m = new miniAd();
                m.setTitle(a[i].title);
                m.setEmvado(a[i].emvadon.ToString());
                m.setArea(a[i].perioxi);
                m.setBaths(a[i].mpanio.ToString() + " Μπάνια");
                m.setRooms(a[i].ypnodomatia.ToString() + " Υπνοδωμάτια");
                m.setPrice("€ " + a[i].timi.ToString());
                m.setThermansi(a[i].thermansi);
                m.setEidos(a[i].eidos);
                m.setPerigrafi(a[i].desc);
                double d = (double)a[i].timi / (double)a[i].emvadon;
                m.Click += (sender1, e1) =>
                {
                    setListingFields(m.getPerioxi(), m.getTimi(), d.ToString(), m.getEmvado(), m.getTypoAk(), m.getThermansi(), m.getEidos(), m.getPerigrafi());
                    vlMainPic.Navigate(ForImages.showAddImages(4, 1));
                    vlMap.Navigate(ForImages.googleMaps(m.getPerioxi(), m.getDieythinsi(), 412, 382));
                    viewListing();
                };
                resultsFlowLayout.Controls.Add(m);
            }

            hideControls();
            showResults();
            footerLeft.Show();
            footerRight.Show();
            footerMiddleB.BringToFront();
        }

        private void logPicbox_Click(object sender, EventArgs e)
        {
            if(!logged)
            {
                new AccountForm().ShowDialog();
            }
            else
            {
                controlLogout_Click(this, e);
            }
        }

        private void profilePicEdit_Click(object sender, EventArgs e)
        {
            add3Dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            add3Dialog.Multiselect = false;
            if (add3Dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = ResizeImage(new Bitmap(add3Dialog.FileName), 250, 189);
                profilePicbox.Image = b;
                userPicbox.Image = b;
                ForImages.imageToString(b);
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
            /*newuseradd.ypnodomatia = Int32.Parse(domatiaTextbox.Text);
            newuseradd.mpanio = Int32.Parse(mpaniaTextbox.Text);
            newuseradd.perioxi = perioxiTextbox.Text;
            add2City.Text = perioxiTextbox.Text;
            newuseradd.timi = Int32.Parse(timiTextbox.Text);
            string eidos;
            if (buyRBtn.Checked) eidos = "Αγορά";
            else eidos = "Ενοικίαση";
            string emvadon = emvadoTextbox.Text;
            string tipos = typeCombo.Text;
            string thermansi = heatingCombo1.Text + " " + heatingCombo2.Text;
            string phone = phoneTextbox.Text;
            string desc = addPerigrafiText.Text;
            string dieythinsi = add2Address.Text;
            */
            addPanel1.Hide();
            addPanel2.BringToFront();
            addPanel2.Show();
        }

        private void add2Next_Click(object sender, EventArgs e)
        {
            string eidos;
            if (buyRBtn.Checked) eidos = "Αγορά";
            else eidos = "Ενοικίαση";
            DataAccess.NewAdd(Int32.Parse(domatiaTextbox.Text), Int32.Parse(mpaniaTextbox.Text), 
                                          email, perioxiTextbox.Text, Int32.Parse(timiTextbox.Text),
                                          eidos, Int32.Parse(emvadoTextbox.Text), typeCombo.Text,
                                          (heatingCombo1.Text + " " + heatingCombo2.Text), phoneTextbox.Text,
                                          addPerigrafiText.Text, add2Address.Text);
            addPanel2.Hide();
            addPanel3.BringToFront();
            addPanel3.Show();
        }
        
        private void add3PicAdd_Click(object sender, EventArgs e)
        {
            if(x<5) { 
                add3Dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                add3Dialog.Multiselect = false;
                if (add3Dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = ResizeImage(new Bitmap(add3Dialog.FileName), 250, 140);
                    ((PictureBox)(add3FlowLayout.Controls[x])).Image = b;
                    ((PictureBox)(add3FlowLayout.Controls[x])).ImageLocation = add3Dialog.FileName;
                    ((PictureBox)(add3FlowLayout.Controls[x])).BorderStyle = BorderStyle.FixedSingle;

                }
                x = x + 1;
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
            bw.RunWorkerAsync();
            controlHomepage_Click(this, e);
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            ForImages.createPhotoDir(newuseradd.sid);
            for (int i = 0; i < add3FlowLayout.Controls.Count; i++)
            {
                if (((PictureBox)(add3FlowLayout.Controls[i])).ImageLocation != null)
                {
                    ForImages.sftpSendImage(newuseradd.sid, ((PictureBox)(add3FlowLayout.Controls[i])).ImageLocation, i);
                }
            }
            x = 0;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < add3FlowLayout.Controls.Count; i++)
            {
                ((PictureBox)(add3FlowLayout.Controls[i])).BorderStyle = BorderStyle.None;
                ((PictureBox)(add3FlowLayout.Controls[i])).Image = null;
            }
        }

        public static void login(User user)
        {
            logged = true;
            flag = true;
            user1 = user;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if(logged && flag)
            {
                name = user1.Name;
                usernameLabel.Text = name;
                email = user1.EmailAddress;
                if(user1.Image!=null)
                {
                    Image im = ForImages.stringToImage(user1.Image);
                    userPicbox.Image = im;
                    profilePicbox.Image = im;
                }
                logPicbox.Image = global::AdopseAddsTeam5.Properties.Resources.outline_logout_white_24dp;
                loadMessages();
                loadUserAds();
                //loadFavorites();
                flag = false;
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

        private void showResults()
        {
            resultsPanel.Show();
            resultsPanel.BringToFront();
            resultsCombo.Show();
            resultsCombo.BringToFront();
            resultsSearchTableLayout.Show();
            resultsSearchTableLayout.BringToFront();
            resultsFilterPanel.Show();
            resultsFilterPanel.BringToFront();
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
                //DataAccess.UserNewEmail(email, profileEmailText.Text);
                //email = profileEmailText.Text;
            }
        }

        private void profileEmailText_VisibleChanged(object sender, EventArgs e)
        {
            profileEmailText.Text = email;
            profileEmailText.Enabled = false;
            profileEmailText.ReadOnly = true;
            profileEmailEdit.Text = "Επεξεργασία";
        }


        private void profileNameEdit_Click(object sender, EventArgs e)
        {
            name = profileNameText.Text;
            if (profileNameEdit.Text == "Επεξεργασία")
            {
                profileNameText.Enabled = true;
                profileNameText.ReadOnly = false;
                profileNameText.Focus();
                profileNameEdit.Text = "Αποθήκευση";
            }
            else
            {
                profileNameText.Enabled = false;
                profileNameText.ReadOnly = true;
                profileNameEdit.Text = "Επεξεργασία";
                DataAccess.UserName(email, profileNameText.Text);
                name = profileNameText.Text;
                usernameLabel.Text = name.ToUpper();
            }
        }


        private void profileNameText_VisibleChanged(object sender, EventArgs e)
        {
            profileNameText.Text = name;
            profileNameText.Enabled = false;
            profileNameText.ReadOnly = true;
            profileNameEdit.Text = "Επεξεργασία";
        }

        private void loadMessages()
        {
            GUI.Main_Form.Message[] m = DataAccess.UserMessages(email);
            for(int i=0; i<m.Length+2; i++)
            {
                //ControlMessage cm = new ControlMessage(m[i].firstname, m[i].lastname, m[i].phone, m[i].email, m[i].desc);
                ControlMessage cm = new ControlMessage("Alexandros" , "Giotas" , "6932123123", "alexandros@gmail.com", "Dokimastiko keimeno");
                notificationsFlowLayout.Controls.Add(cm);
            }
        }

        /*private void loadFavorites()
        {
            Adds[] a = DataAccess.FavoriteAdds(email);
            for(int i=0; i<a.Length; i++)
            {
                miniAd m = new miniAd();
                m.setTitle(a[i].eidos + " " + a[i].emvadon);
                m.setDate("10/5/21");
                m.setArea(a[i].perioxi);
                m.setRooms(a[i].ypnodomatia.ToString());
                m.setBaths(a[i].mpanio.ToString());
                m.setPrice(a[i].timi + " - " + a[i].title);
                favoritesFlowLayout.Controls.Add(m);
            }
        }*/

        private void loadUserAds()
        {
            List<Adds> userAds = new List<Adds>();
            userAds = DataAccess.UserAdds(email);
            for(int i=0; i<userAds.Count; i++)
            {
                ControlAd c = new ControlAd();
                c.setPrice("€ " + (userAds[i].timi).ToString());
                c.setInfo(userAds[i].eidos + ", " + userAds[i].perioxi + ", " + userAds[i].title + ", " + (userAds[i].emvadon).ToString() + " τ.μ.");
                c.Name = "Ad" + userAds[i].sid.ToString();
                profileFlowLayout.Controls.Add(c);
            }
        }

        private void searchFilterRefresh_Click(object sender, EventArgs e)
        {

        }

        private void appNamePicbox_Click(object sender, EventArgs e)
        {
            controlHomepage_Click(this, e);
        }

        private void resultsSearchBtn_Click(object sender, EventArgs e)
        {
            resultsFlowLayout.Controls.Clear();
            List<Adds> a = LuceneSearch.Search(resultsSearchbox.Text).ToList();
            for (int i = 0; i < a.Count; i++)
            {
                miniAd m = new miniAd();
                m.setTitle(a[i].title);
                m.setEmvado(a[i].emvadon.ToString());
                m.setArea(a[i].perioxi);
                m.setBaths(a[i].mpanio.ToString() + " Μπάνια");
                m.setRooms(a[i].ypnodomatia.ToString() + " Υπνοδωμάτια");
                m.setPrice("€ " + a[i].timi.ToString());
                m.setThermansi(a[i].thermansi);
                m.setEidos(a[i].eidos);
                m.setPerigrafi(a[i].desc);
                double d = (double)a[i].timi / (double)a[i].emvadon;
                m.Click += (sender1, e1) =>
                {
                    int z = ForImages.imageCounter(m.getId());
                    setListingFields(m.getPerioxi(), m.getTimi(), d.ToString(), m.getEmvado(), m.getTypoAk(), m.getThermansi(), m.getEidos(), m.getPerigrafi());
                    vlMap.Navigate(ForImages.googleMaps(m.getPerioxi(), m.getDieythinsi(), 420, 235));
                    for(int j=0; j<z; j++)
                    {
                    if (j == 0)
                        {
                            vlMainPic.Navigate(ForImages.showAddImages(0, 0));
                        }
                        wb[j].Navigate(ForImages.showAddImages(0, 1));
                    }
                    viewListing();
                };
                resultsFlowLayout.Controls.Add(m);
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            resultsSearchbox.Text = searchTextbox.Text;
        }

        private void add2Search_Click(object sender, EventArgs e)
        {
            string s = ForImages.googleMaps(add2City.Text, add2Address.Text, 600, 400);
            add2Browser.Navigate(s);
        }

        //Enter|Leave commands for text fields.

        private void add2Address_Enter(object sender, EventArgs e)
        {
            if (add2Address.Text == "Διεύθυνση")
            {
                add2Address.Text = "";
                add2Address.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void add2Address_Leave(object sender, EventArgs e)
        {
            if (add2Address.Text == "")
            {
                add2Address.Text = "Διεύθυνση";
                add2Address.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void add2City_Enter(object sender, EventArgs e)
        {
            if (add2City.Text == "Πόλη")
            {
                add2City.Text = "";
                add2City.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void add2City_Leave(object sender, EventArgs e)
        {
            if (add2City.Text == "")
            {
                add2City.Text = "Πόλη";
                add2City.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void domatiaTextbox_Enter(object sender, EventArgs e)
        {
            if (domatiaTextbox.Text == "π.χ. 2")
            {
                domatiaTextbox.Text = "";
                domatiaTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void domatiaTextbox_Leave(object sender, EventArgs e)
        {
            if (domatiaTextbox.Text == "")
            {
                domatiaTextbox.Text = "π.χ. 2";
                domatiaTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void mpaniaTextbox_Enter(object sender, EventArgs e)
        {
            if (mpaniaTextbox.Text == "π.χ. 1")
            {
                mpaniaTextbox.Text = "";
                mpaniaTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void mpaniaTextbox_Leave(object sender, EventArgs e)
        {
            if (mpaniaTextbox.Text == "")
            {
                mpaniaTextbox.Text = "π.χ. 1";
                mpaniaTextbox.ForeColor = System.Drawing.Color.DarkGray;
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

        private void profileEmailText_Leave(object sender, EventArgs e)
        {
            profileEmailText.Text = email;
            profileEmailText.Enabled = false;
            profileEmailText.ReadOnly = true;
            profileEmailEdit.Text = "Επεξεργασία";
        }

        private void profileNameText_Leave(object sender, EventArgs e)
        {
            profileNameText.Text = name;
            profileNameText.Enabled = false;
            profileNameText.ReadOnly = true;
            profileNameEdit.Text = "Επεξεργασία";
        }

        private void perioxiTextbox_TextChanged(object sender, EventArgs e)
        {
            add2City.Text = perioxiTextbox.Text;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LuceneSearch.ClearLuceneIndex();
        }
    }
}
