﻿
namespace AdopseAddsTeam5.GUI.Main_Form
{
    partial class Account
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logRegTabControl = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPassLabel = new System.Windows.Forms.Label();
            this.loginConnectLabel = new System.Windows.Forms.Label();
            this.loginEmailTextbox = new System.Windows.Forms.TextBox();
            this.loginPassTextbox = new System.Windows.Forms.TextBox();
            this.loginForgotLabel = new System.Windows.Forms.Label();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.registerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rEmailLabel = new System.Windows.Forms.Label();
            this.rPassLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.rEmailTextbox = new System.Windows.Forms.TextBox();
            this.rPassTextbox1 = new System.Windows.Forms.TextBox();
            this.rPassTextbox2 = new System.Windows.Forms.TextBox();
            this.rPasswordMessage = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayout.SuspendLayout();
            this.logRegTabControl.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.loginTableLayout.SuspendLayout();
            this.registerTab.SuspendLayout();
            this.registerTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(376, 40);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Καλωσήρθατε στο";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.BackColor = System.Drawing.Color.White;
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.logRegTabControl, 0, 2);
            this.mainTableLayout.Controls.Add(this.headerLabel, 0, 0);
            this.mainTableLayout.Controls.Add(this.logoPicBox, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(382, 418);
            this.mainTableLayout.TabIndex = 0;
            // 
            // logRegTabControl
            // 
            this.logRegTabControl.Controls.Add(this.loginTab);
            this.logRegTabControl.Controls.Add(this.registerTab);
            this.logRegTabControl.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.logRegTabControl.HotTrack = true;
            this.logRegTabControl.Location = new System.Drawing.Point(3, 113);
            this.logRegTabControl.Multiline = true;
            this.logRegTabControl.Name = "logRegTabControl";
            this.logRegTabControl.SelectedIndex = 0;
            this.logRegTabControl.Size = new System.Drawing.Size(376, 298);
            this.logRegTabControl.TabIndex = 1;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginTableLayout);
            this.loginTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginTab.Location = new System.Drawing.Point(4, 29);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTab.Size = new System.Drawing.Size(368, 265);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Σύνδεση";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // loginTableLayout
            // 
            this.loginTableLayout.ColumnCount = 1;
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginTableLayout.Controls.Add(this.LoginEmailLabel, 0, 0);
            this.loginTableLayout.Controls.Add(this.LoginPassLabel, 0, 2);
            this.loginTableLayout.Controls.Add(this.loginConnectLabel, 0, 5);
            this.loginTableLayout.Controls.Add(this.loginEmailTextbox, 0, 1);
            this.loginTableLayout.Controls.Add(this.loginPassTextbox, 0, 3);
            this.loginTableLayout.Controls.Add(this.loginForgotLabel, 0, 6);
            this.loginTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTableLayout.Location = new System.Drawing.Point(3, 3);
            this.loginTableLayout.Name = "loginTableLayout";
            this.loginTableLayout.RowCount = 7;
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.loginTableLayout.Size = new System.Drawing.Size(362, 259);
            this.loginTableLayout.TabIndex = 0;
            // 
            // LoginEmailLabel
            // 
            this.LoginEmailLabel.AutoSize = true;
            this.LoginEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginEmailLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginEmailLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginEmailLabel.Name = "LoginEmailLabel";
            this.LoginEmailLabel.Size = new System.Drawing.Size(356, 35);
            this.LoginEmailLabel.TabIndex = 0;
            this.LoginEmailLabel.Text = "Email";
            this.LoginEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginPassLabel
            // 
            this.LoginPassLabel.AutoSize = true;
            this.LoginPassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPassLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginPassLabel.Location = new System.Drawing.Point(3, 75);
            this.LoginPassLabel.Name = "LoginPassLabel";
            this.LoginPassLabel.Size = new System.Drawing.Size(356, 35);
            this.LoginPassLabel.TabIndex = 1;
            this.LoginPassLabel.Text = "Κωδικός";
            this.LoginPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginConnectLabel
            // 
            this.loginConnectLabel.AutoSize = true;
            this.loginConnectLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginConnectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginConnectLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginConnectLabel.ForeColor = System.Drawing.Color.White;
            this.loginConnectLabel.Location = new System.Drawing.Point(3, 189);
            this.loginConnectLabel.Name = "loginConnectLabel";
            this.loginConnectLabel.Size = new System.Drawing.Size(356, 40);
            this.loginConnectLabel.TabIndex = 2;
            this.loginConnectLabel.Text = "Σύνδεση";
            this.loginConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginEmailTextbox
            // 
            this.loginEmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginEmailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginEmailTextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.loginEmailTextbox.Location = new System.Drawing.Point(3, 38);
            this.loginEmailTextbox.Name = "loginEmailTextbox";
            this.loginEmailTextbox.Size = new System.Drawing.Size(356, 31);
            this.loginEmailTextbox.TabIndex = 3;
            this.loginEmailTextbox.Text = "Συμπλήρωσε email";
            // 
            // loginPassTextbox
            // 
            this.loginPassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPassTextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginPassTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.loginPassTextbox.Location = new System.Drawing.Point(3, 113);
            this.loginPassTextbox.Name = "loginPassTextbox";
            this.loginPassTextbox.Size = new System.Drawing.Size(356, 31);
            this.loginPassTextbox.TabIndex = 4;
            this.loginPassTextbox.Text = "Συμπλήρωσε κωδικό";
            // 
            // loginForgotLabel
            // 
            this.loginForgotLabel.AutoSize = true;
            this.loginForgotLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginForgotLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginForgotLabel.Location = new System.Drawing.Point(3, 229);
            this.loginForgotLabel.Name = "loginForgotLabel";
            this.loginForgotLabel.Size = new System.Drawing.Size(356, 30);
            this.loginForgotLabel.TabIndex = 5;
            this.loginForgotLabel.Text = "Ξέχασα τον κωδικό μου";
            this.loginForgotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.registerTableLayout);
            this.registerTab.Location = new System.Drawing.Point(4, 29);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(368, 265);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Εγγραφή";
            this.registerTab.UseVisualStyleBackColor = true;
            // 
            // registerTableLayout
            // 
            this.registerTableLayout.ColumnCount = 1;
            this.registerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registerTableLayout.Controls.Add(this.rEmailLabel, 0, 0);
            this.registerTableLayout.Controls.Add(this.rPassLabel, 0, 2);
            this.registerTableLayout.Controls.Add(this.registerLabel, 0, 6);
            this.registerTableLayout.Controls.Add(this.rEmailTextbox, 0, 1);
            this.registerTableLayout.Controls.Add(this.rPassTextbox1, 0, 3);
            this.registerTableLayout.Controls.Add(this.rPassTextbox2, 0, 4);
            this.registerTableLayout.Controls.Add(this.rPasswordMessage, 0, 5);
            this.registerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerTableLayout.Location = new System.Drawing.Point(3, 3);
            this.registerTableLayout.Name = "registerTableLayout";
            this.registerTableLayout.RowCount = 7;
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.registerTableLayout.Size = new System.Drawing.Size(362, 259);
            this.registerTableLayout.TabIndex = 0;
            // 
            // rEmailLabel
            // 
            this.rEmailLabel.AutoSize = true;
            this.rEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rEmailLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rEmailLabel.Location = new System.Drawing.Point(3, 0);
            this.rEmailLabel.Name = "rEmailLabel";
            this.rEmailLabel.Size = new System.Drawing.Size(356, 30);
            this.rEmailLabel.TabIndex = 0;
            this.rEmailLabel.Text = "Email";
            this.rEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rPassLabel
            // 
            this.rPassLabel.AutoSize = true;
            this.rPassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPassLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rPassLabel.Location = new System.Drawing.Point(3, 65);
            this.rPassLabel.Name = "rPassLabel";
            this.rPassLabel.Size = new System.Drawing.Size(356, 30);
            this.rPassLabel.TabIndex = 1;
            this.rPassLabel.Text = "Κωδικός";
            this.rPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.registerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(3, 219);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(356, 40);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Εγγραφή";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rEmailTextbox
            // 
            this.rEmailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rEmailTextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.rEmailTextbox.Location = new System.Drawing.Point(3, 33);
            this.rEmailTextbox.Name = "rEmailTextbox";
            this.rEmailTextbox.Size = new System.Drawing.Size(356, 31);
            this.rEmailTextbox.TabIndex = 3;
            this.rEmailTextbox.Text = "Συμπλήρωσε email";
            // 
            // rPassTextbox1
            // 
            this.rPassTextbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPassTextbox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rPassTextbox1.ForeColor = System.Drawing.Color.DarkGray;
            this.rPassTextbox1.Location = new System.Drawing.Point(3, 98);
            this.rPassTextbox1.Name = "rPassTextbox1";
            this.rPassTextbox1.Size = new System.Drawing.Size(356, 31);
            this.rPassTextbox1.TabIndex = 4;
            this.rPassTextbox1.Text = "Συμπλήρωσε κωδικό";
            // 
            // rPassTextbox2
            // 
            this.rPassTextbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPassTextbox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rPassTextbox2.ForeColor = System.Drawing.Color.DarkGray;
            this.rPassTextbox2.Location = new System.Drawing.Point(3, 133);
            this.rPassTextbox2.Name = "rPassTextbox2";
            this.rPassTextbox2.Size = new System.Drawing.Size(356, 31);
            this.rPassTextbox2.TabIndex = 5;
            this.rPassTextbox2.Text = "Επιβεβαίωση κωδικού";
            // 
            // rPasswordMessage
            // 
            this.rPasswordMessage.AutoSize = true;
            this.rPasswordMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPasswordMessage.Location = new System.Drawing.Point(3, 165);
            this.rPasswordMessage.Name = "rPasswordMessage";
            this.rPasswordMessage.Size = new System.Drawing.Size(356, 54);
            this.rPasswordMessage.TabIndex = 6;
            this.rPasswordMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPicBox
            // 
            this.logoPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicBox.Image = global::AdopseAddsTeam5.Properties.Resources.name_color;
            this.logoPicBox.Location = new System.Drawing.Point(3, 43);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(376, 64);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 2;
            this.logoPicBox.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 418);
            this.Controls.Add(this.mainTableLayout);
            this.MaximumSize = new System.Drawing.Size(400, 465);
            this.MinimumSize = new System.Drawing.Size(400, 465);
            this.Name = "Account";
            this.Text = "Λογαριασμός";
            this.mainTableLayout.ResumeLayout(false);
            this.logRegTabControl.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTableLayout.ResumeLayout(false);
            this.loginTableLayout.PerformLayout();
            this.registerTab.ResumeLayout(false);
            this.registerTableLayout.ResumeLayout(false);
            this.registerTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TabControl logRegTabControl;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TableLayoutPanel loginTableLayout;
        private System.Windows.Forms.Label LoginEmailLabel;
        private System.Windows.Forms.Label LoginPassLabel;
        private System.Windows.Forms.Label loginConnectLabel;
        private System.Windows.Forms.TextBox loginEmailTextbox;
        private System.Windows.Forms.TextBox loginPassTextbox;
        private System.Windows.Forms.Label loginForgotLabel;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.TableLayoutPanel registerTableLayout;
        private System.Windows.Forms.Label rEmailLabel;
        private System.Windows.Forms.Label rPassLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox rEmailTextbox;
        private System.Windows.Forms.TextBox rPassTextbox1;
        private System.Windows.Forms.TextBox rPassTextbox2;
        private System.Windows.Forms.Label rPasswordMessage;
    }
}