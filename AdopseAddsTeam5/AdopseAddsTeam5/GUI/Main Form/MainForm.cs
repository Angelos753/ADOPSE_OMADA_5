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

        private bool logged = true;
        private bool h = true;

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
            if (this.Size.Width < 1218)
            {
                leftFooter.Hide();
                rightFooter.Hide();
                if (!h) sideMenuPanel.Hide();
            }
            else
            {
                leftFooter.Show();
                rightFooter.Show();
            }
        }

        private void hideControls()
        {
            sideMenuPanel.Hide();
            searchTableLayout.Hide();
            choicePanel.Hide();
            profilePanel.Hide();
            watermarkPicbox.Hide();
            footerMiddle.Hide();
            leftFooter.Hide();
            rightFooter.Hide();
            addPanel1.Hide();
            addPanel2.Hide();
            addPanel3.Hide();
            h = false;
        }

        private void sideMenuPicbox_Click(object sender, EventArgs e)
        {
            if(logged && (this.Size.Width > 1218 || h))
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
            //searchBtn.Text = "Width is " + this.Size.Width + " pixels";
        }

        private void controlBuy1_Click(object sender, EventArgs e)
        {

        }

        private void controlRent1_Click(object sender, EventArgs e)
        {

        }

        private void controlAdd1_Click(object sender, EventArgs e)
        {
            hideControls();
            addPanel1.Show();
            addPanel1.BringToFront();
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
            hideControls();
            addPanel1.Show();
            addPanel1.BringToFront();
        }

        private void add1Next_Click(object sender, EventArgs e)
        {
            addPanel1.SendToBack();
            addPanel1.Hide();
            addPanel2.BringToFront();
            addPanel2.Show();
        }

        private void add2Next_Click(object sender, EventArgs e)
        {
            addPanel2.SendToBack();
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
            addPanel3.SendToBack();
            addPanel3.Hide();
            controlHomepage_Click(this, e);
        }
    }

}
