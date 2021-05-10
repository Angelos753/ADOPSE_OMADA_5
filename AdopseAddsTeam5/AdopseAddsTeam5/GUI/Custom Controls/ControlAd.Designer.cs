
namespace AdopseAddsTeam5.GUI.Custom_Controls
{
    partial class ControlAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAd));
            this.adPicbox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // adPicbox
            // 
            this.adPicbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adPicbox.Image = ((System.Drawing.Image)(resources.GetObject("adPicbox.Image")));
            this.adPicbox.Location = new System.Drawing.Point(0, 0);
            this.adPicbox.Margin = new System.Windows.Forms.Padding(0);
            this.adPicbox.Name = "adPicbox";
            this.adPicbox.Size = new System.Drawing.Size(75, 75);
            this.adPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adPicbox.TabIndex = 0;
            this.adPicbox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.priceLabel.Location = new System.Drawing.Point(90, 25);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(106, 24);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "€150.000 -";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.infoLabel.Location = new System.Drawing.Point(196, 25);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(696, 23);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Πώληση, Διαμέρισμα, 82 τ.μ.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.White;
            this.deleteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteLabel.Location = new System.Drawing.Point(879, 25);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(105, 26);
            this.deleteLabel.TabIndex = 3;
            this.deleteLabel.Text = "Διαγραφή";
            this.deleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // ControlAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.adPicbox);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "ControlAd";
            this.Size = new System.Drawing.Size(1001, 75);
            ((System.ComponentModel.ISupportInitialize)(this.adPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox adPicbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label deleteLabel;

        public void setPrice(string price)
        {
            priceLabel.Text = price;
        }

        public void setInfo(string info)
        {
            infoLabel.Text = info;
        }
    }
}
