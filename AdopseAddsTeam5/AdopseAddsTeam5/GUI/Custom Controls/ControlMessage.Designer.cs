
namespace AdopseAddsTeam5.GUI.Custom_Controls
{
    partial class ControlMessage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.provoliLabel = new System.Windows.Forms.Label();
            this.diagrafiLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.favoritePicbox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritePicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.provoliLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.diagrafiLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.favoritePicbox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Μήνυμα";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // provoliLabel
            // 
            this.provoliLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.provoliLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.provoliLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.provoliLabel.ForeColor = System.Drawing.Color.White;
            this.provoliLabel.Location = new System.Drawing.Point(344, 3);
            this.provoliLabel.Margin = new System.Windows.Forms.Padding(0);
            this.provoliLabel.Name = "provoliLabel";
            this.provoliLabel.Size = new System.Drawing.Size(100, 25);
            this.provoliLabel.TabIndex = 1;
            this.provoliLabel.Text = "Προβολή";
            this.provoliLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.provoliLabel.Click += new System.EventHandler(this.provoliLabel_Click);
            // 
            // diagrafiLabel
            // 
            this.diagrafiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diagrafiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.diagrafiLabel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.diagrafiLabel.ForeColor = System.Drawing.Color.White;
            this.diagrafiLabel.Location = new System.Drawing.Point(533, 3);
            this.diagrafiLabel.Margin = new System.Windows.Forms.Padding(0);
            this.diagrafiLabel.Name = "diagrafiLabel";
            this.diagrafiLabel.Size = new System.Drawing.Size(100, 25);
            this.diagrafiLabel.TabIndex = 2;
            this.diagrafiLabel.Text = "Διαγραφή";
            this.diagrafiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diagrafiLabel.Click += new System.EventHandler(this.diagrafiLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label4.Location = new System.Drawing.Point(0, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Διάφορες πληροφορίες";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // favoritePicbox
            // 
            this.favoritePicbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.favoritePicbox.Image = global::AdopseAddsTeam5.Properties.Resources.outline_grade_black_24dp;
            this.favoritePicbox.Location = new System.Drawing.Point(947, 13);
            this.favoritePicbox.Margin = new System.Windows.Forms.Padding(0);
            this.favoritePicbox.Name = "favoritePicbox";
            this.tableLayoutPanel1.SetRowSpan(this.favoritePicbox, 2);
            this.favoritePicbox.Size = new System.Drawing.Size(32, 38);
            this.favoritePicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.favoritePicbox.TabIndex = 4;
            this.favoritePicbox.TabStop = false;
            this.favoritePicbox.Click += new System.EventHandler(this.favoritePicbox_Click);
            // 
            // ControlMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Name = "ControlMessage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(803, 71);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritePicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label provoliLabel;
        private System.Windows.Forms.Label diagrafiLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox favoritePicbox;
    }
}
