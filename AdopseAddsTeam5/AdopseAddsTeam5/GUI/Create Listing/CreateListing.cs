using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5.GUI.Create_Listing
{
    public partial class CreateListing : Form
    {

        public PictureBox[] pics = new PictureBox[10];
        public int x = 0;

        public CreateListing()
        {
            InitializeComponent();
            pics[0] = this.pictureBox1;
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

        private void nextLabel1_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Remove(this.firstTableLayout);
            this.mainPanel.Controls.Add(this.secondTableLayout);
            this.secondTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondTableLayout.Visible = true;
        }

        private void nextLabel2_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Remove(this.secondTableLayout);
            this.mainPanel.Controls.Add(this.thirdTableLayout);
            this.thirdTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdTableLayout.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = ResizeImage(new Bitmap(dialog.FileName), 90, 90);
                pics[x].Image = b;
            }
        }
    }
}
