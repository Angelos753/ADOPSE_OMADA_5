
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.adPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.adPic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.priceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.priceLabel.Location = new System.Drawing.Point(80, 5);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 65);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "€ 150000";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.infoLabel.Location = new System.Drawing.Point(180, 5);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(663, 65);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Διάφορες πληροφορίες για το ακίνητο";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteLabel
            // 
            this.deleteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteLabel.BackColor = System.Drawing.Color.Firebrick;
            this.deleteLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteLabel.ForeColor = System.Drawing.Color.White;
            this.deleteLabel.Location = new System.Drawing.Point(843, 22);
            this.deleteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(101, 30);
            this.deleteLabel.TabIndex = 3;
            this.deleteLabel.Text = "Διαγραφή";
            this.deleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // adPic
            // 
            this.adPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adPic.Image = ((System.Drawing.Image)(resources.GetObject("adPic.Image")));
            this.adPic.Location = new System.Drawing.Point(5, 5);
            this.adPic.Margin = new System.Windows.Forms.Padding(0);
            this.adPic.Name = "adPic";
            this.adPic.Size = new System.Drawing.Size(75, 65);
            this.adPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adPic.TabIndex = 0;
            this.adPic.TabStop = false;
            // 
            // ControlAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(40, 10, 40, 0);
            this.Name = "ControlAd";
            this.Size = new System.Drawing.Size(950, 75);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public void setPrice(string price)
        {
            priceLabel.Text = price;
        }

        public void setInfo(string info)
        {
            infoLabel.Text = info;
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox adPic;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label deleteLabel;
    }
}
