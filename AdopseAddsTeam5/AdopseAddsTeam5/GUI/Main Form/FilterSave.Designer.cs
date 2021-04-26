
namespace AdopseAddsTeam5.GUI.Main_Form
{
    partial class FilterSave
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterSave));
            this.saveFilterText = new System.Windows.Forms.TextBox();
            this.radioGroup = new System.Windows.Forms.TableLayoutPanel();
            this.filterSaveRB3 = new System.Windows.Forms.RadioButton();
            this.filterSaveRB2 = new System.Windows.Forms.RadioButton();
            this.filterSaveRB1 = new System.Windows.Forms.RadioButton();
            this.filterSaveBtn = new System.Windows.Forms.Label();
            this.irrelevant3 = new System.Windows.Forms.Label();
            this.irrelevant2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.irrelevant1 = new System.Windows.Forms.Label();
            this.filterSaveTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.radioGroup.SuspendLayout();
            this.filterSaveTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFilterText
            // 
            this.saveFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFilterText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveFilterText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveFilterText.ForeColor = System.Drawing.Color.Gray;
            this.saveFilterText.Location = new System.Drawing.Point(10, 88);
            this.saveFilterText.Margin = new System.Windows.Forms.Padding(0);
            this.saveFilterText.Name = "saveFilterText";
            this.saveFilterText.Size = new System.Drawing.Size(362, 30);
            this.saveFilterText.TabIndex = 6;
            this.saveFilterText.Text = "Τούμπα";
            // 
            // radioGroup
            // 
            this.radioGroup.ColumnCount = 1;
            this.radioGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.radioGroup.Controls.Add(this.filterSaveRB3, 0, 2);
            this.radioGroup.Controls.Add(this.filterSaveRB2, 0, 1);
            this.radioGroup.Controls.Add(this.filterSaveRB1, 0, 0);
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup.Location = new System.Drawing.Point(10, 159);
            this.radioGroup.Margin = new System.Windows.Forms.Padding(0);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Padding = new System.Windows.Forms.Padding(10);
            this.radioGroup.RowCount = 3;
            this.radioGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.radioGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.radioGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.radioGroup.Size = new System.Drawing.Size(362, 112);
            this.radioGroup.TabIndex = 5;
            // 
            // filterSaveRB3
            // 
            this.filterSaveRB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterSaveRB3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filterSaveRB3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.filterSaveRB3.Location = new System.Drawing.Point(10, 70);
            this.filterSaveRB3.Margin = new System.Windows.Forms.Padding(0);
            this.filterSaveRB3.Name = "filterSaveRB3";
            this.filterSaveRB3.Size = new System.Drawing.Size(342, 32);
            this.filterSaveRB3.TabIndex = 0;
            this.filterSaveRB3.Text = "Χωρίς ειδοποιήσεις";
            this.filterSaveRB3.UseVisualStyleBackColor = true;
            // 
            // filterSaveRB2
            // 
            this.filterSaveRB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterSaveRB2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filterSaveRB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.filterSaveRB2.Location = new System.Drawing.Point(10, 40);
            this.filterSaveRB2.Margin = new System.Windows.Forms.Padding(0);
            this.filterSaveRB2.Name = "filterSaveRB2";
            this.filterSaveRB2.Size = new System.Drawing.Size(342, 30);
            this.filterSaveRB2.TabIndex = 1;
            this.filterSaveRB2.Text = "Καθημερινά";
            this.filterSaveRB2.UseVisualStyleBackColor = true;
            // 
            // filterSaveRB1
            // 
            this.filterSaveRB1.Checked = true;
            this.filterSaveRB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterSaveRB1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filterSaveRB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.filterSaveRB1.Location = new System.Drawing.Point(10, 10);
            this.filterSaveRB1.Margin = new System.Windows.Forms.Padding(0);
            this.filterSaveRB1.Name = "filterSaveRB1";
            this.filterSaveRB1.Size = new System.Drawing.Size(342, 30);
            this.filterSaveRB1.TabIndex = 2;
            this.filterSaveRB1.TabStop = true;
            this.filterSaveRB1.Text = "Άμεσα";
            this.filterSaveRB1.UseVisualStyleBackColor = true;
            // 
            // filterSaveBtn
            // 
            this.filterSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.filterSaveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filterSaveBtn.ForeColor = System.Drawing.Color.White;
            this.filterSaveBtn.Location = new System.Drawing.Point(114, 290);
            this.filterSaveBtn.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.filterSaveBtn.Name = "filterSaveBtn";
            this.filterSaveBtn.Size = new System.Drawing.Size(153, 54);
            this.filterSaveBtn.TabIndex = 4;
            this.filterSaveBtn.Text = "Αποθήκευση";
            this.filterSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // irrelevant3
            // 
            this.irrelevant3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrelevant3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.irrelevant3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.irrelevant3.Location = new System.Drawing.Point(10, 122);
            this.irrelevant3.Margin = new System.Windows.Forms.Padding(0);
            this.irrelevant3.Name = "irrelevant3";
            this.irrelevant3.Size = new System.Drawing.Size(362, 37);
            this.irrelevant3.TabIndex = 3;
            this.irrelevant3.Text = "Συχνότητα ειδοποιήσεων";
            this.irrelevant3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // irrelevant2
            // 
            this.irrelevant2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrelevant2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.irrelevant2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.irrelevant2.Location = new System.Drawing.Point(10, 48);
            this.irrelevant2.Margin = new System.Windows.Forms.Padding(0);
            this.irrelevant2.Name = "irrelevant2";
            this.irrelevant2.Size = new System.Drawing.Size(362, 37);
            this.irrelevant2.TabIndex = 2;
            this.irrelevant2.Text = "Όνομα αποθήκευσης";
            this.irrelevant2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 1);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // irrelevant1
            // 
            this.irrelevant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrelevant1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.irrelevant1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));
            this.irrelevant1.Location = new System.Drawing.Point(10, 10);
            this.irrelevant1.Margin = new System.Windows.Forms.Padding(0);
            this.irrelevant1.Name = "irrelevant1";
            this.irrelevant1.Size = new System.Drawing.Size(362, 37);
            this.irrelevant1.TabIndex = 0;
            this.irrelevant1.Text = "Αποθήκευση Φίλτρων";
            this.irrelevant1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterSaveTableLayout
            // 
            this.filterSaveTableLayout.BackColor = System.Drawing.Color.White;
            this.filterSaveTableLayout.ColumnCount = 1;
            this.filterSaveTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterSaveTableLayout.Controls.Add(this.irrelevant1, 0, 0);
            this.filterSaveTableLayout.Controls.Add(this.label2, 0, 1);
            this.filterSaveTableLayout.Controls.Add(this.irrelevant2, 0, 2);
            this.filterSaveTableLayout.Controls.Add(this.irrelevant3, 0, 4);
            this.filterSaveTableLayout.Controls.Add(this.radioGroup, 0, 5);
            this.filterSaveTableLayout.Controls.Add(this.saveFilterText, 0, 3);
            this.filterSaveTableLayout.Controls.Add(this.filterSaveBtn, 0, 6);
            this.filterSaveTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterSaveTableLayout.Location = new System.Drawing.Point(0, 0);
            this.filterSaveTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.filterSaveTableLayout.Name = "filterSaveTableLayout";
            this.filterSaveTableLayout.Padding = new System.Windows.Forms.Padding(10);
            this.filterSaveTableLayout.RowCount = 7;
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filterSaveTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.filterSaveTableLayout.Size = new System.Drawing.Size(382, 358);
            this.filterSaveTableLayout.TabIndex = 0;
            // 
            // FilterSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 358);
            this.Controls.Add(this.filterSaveTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 405);
            this.MinimumSize = new System.Drawing.Size(400, 405);
            this.Name = "FilterSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Αποθήκευση φίλτρων";
            this.radioGroup.ResumeLayout(false);
            this.filterSaveTableLayout.ResumeLayout(false);
            this.filterSaveTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox saveFilterText;
        private System.Windows.Forms.TableLayoutPanel radioGroup;
        private System.Windows.Forms.RadioButton filterSaveRB3;
        private System.Windows.Forms.RadioButton filterSaveRB2;
        private System.Windows.Forms.RadioButton filterSaveRB1;
        private System.Windows.Forms.Label filterSaveBtn;
        private System.Windows.Forms.Label irrelevant3;
        private System.Windows.Forms.Label irrelevant2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label irrelevant1;
        private System.Windows.Forms.TableLayoutPanel filterSaveTableLayout;
    }
}