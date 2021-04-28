
namespace AdopseAddsTeam5.GUI.Custom_Controls
{
    partial class miniAd
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.favPicBox = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.bedrooms = new System.Windows.Forms.Label();
            this.baths = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.favPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // favPicBox
            // 
            this.favPicBox.Image = global::AdopseAddsTeam5.Properties.Resources.outline_favorite_white_24dp;
            this.favPicBox.Location = new System.Drawing.Point(0, 0);
            this.favPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.favPicBox.Name = "favPicBox";
            this.favPicBox.Size = new System.Drawing.Size(25, 25);
            this.favPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.favPicBox.TabIndex = 1;
            this.favPicBox.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Margin = new System.Windows.Forms.Padding(0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(150, 150);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.title.Location = new System.Drawing.Point(150, 3);
            this.title.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(187, 23);
            this.title.TabIndex = 2;
            this.title.Text = "Διαμέρισμα - 85 τ.μ.";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.area.ForeColor = System.Drawing.Color.DimGray;
            this.area.Location = new System.Drawing.Point(150, 31);
            this.area.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(110, 19);
            this.area.TabIndex = 3;
            this.area.Text = "Κάτω Τούμπα";
            this.area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Location = new System.Drawing.Point(150, 54);
            this.date.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(64, 19);
            this.date.TabIndex = 4;
            this.date.Text = "23/3/21";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bedrooms
            // 
            this.bedrooms.AutoSize = true;
            this.bedrooms.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bedrooms.ForeColor = System.Drawing.Color.DimGray;
            this.bedrooms.Location = new System.Drawing.Point(150, 77);
            this.bedrooms.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.bedrooms.Name = "bedrooms";
            this.bedrooms.Size = new System.Drawing.Size(122, 19);
            this.bedrooms.TabIndex = 5;
            this.bedrooms.Text = "2 Υπνοδωμάτια";
            this.bedrooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baths
            // 
            this.baths.AutoSize = true;
            this.baths.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.baths.ForeColor = System.Drawing.Color.DimGray;
            this.baths.Location = new System.Drawing.Point(150, 100);
            this.baths.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.baths.Name = "baths";
            this.baths.Size = new System.Drawing.Size(77, 19);
            this.baths.TabIndex = 6;
            this.baths.Text = "1 Μπάνιο";
            this.baths.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.price.Location = new System.Drawing.Point(150, 123);
            this.price.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(99, 24);
            this.price.TabIndex = 7;
            this.price.Text = "€ 150.000";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miniAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.price);
            this.Controls.Add(this.baths);
            this.Controls.Add(this.bedrooms);
            this.Controls.Add(this.date);
            this.Controls.Add(this.area);
            this.Controls.Add(this.title);
            this.Controls.Add(this.favPicBox);
            this.Controls.Add(this.picBox);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "miniAd";
            this.Size = new System.Drawing.Size(400, 150);
            ((System.ComponentModel.ISupportInitialize)(this.favPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox favPicBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label bedrooms;
        private System.Windows.Forms.Label baths;
        private System.Windows.Forms.Label price;
    }
}
