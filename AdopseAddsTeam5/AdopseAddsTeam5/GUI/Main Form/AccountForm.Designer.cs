
namespace AdopseAddsTeam5.GUI.Main_Form
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
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
            this.headerLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.headerLabel.Location = new System.Drawing.Point(2, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(284, 32);
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
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(288, 346);
            this.mainTableLayout.TabIndex = 0;
            // 
            // logRegTabControl
            // 
            this.logRegTabControl.Controls.Add(this.loginTab);
            this.logRegTabControl.Controls.Add(this.registerTab);
            this.logRegTabControl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.logRegTabControl.HotTrack = true;
            this.logRegTabControl.Location = new System.Drawing.Point(2, 91);
            this.logRegTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.logRegTabControl.Multiline = true;
            this.logRegTabControl.Name = "logRegTabControl";
            this.logRegTabControl.SelectedIndex = 0;
            this.logRegTabControl.Size = new System.Drawing.Size(282, 242);
            this.logRegTabControl.TabIndex = 1;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginTableLayout);
            this.loginTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginTab.Location = new System.Drawing.Point(4, 25);
            this.loginTab.Margin = new System.Windows.Forms.Padding(2);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(2);
            this.loginTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTab.Size = new System.Drawing.Size(274, 213);
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
            this.loginTableLayout.Location = new System.Drawing.Point(2, 2);
            this.loginTableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.loginTableLayout.Name = "loginTableLayout";
            this.loginTableLayout.RowCount = 7;
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.loginTableLayout.Size = new System.Drawing.Size(270, 209);
            this.loginTableLayout.TabIndex = 0;
            // 
            // LoginEmailLabel
            // 
            this.LoginEmailLabel.AutoSize = true;
            this.LoginEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginEmailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginEmailLabel.Location = new System.Drawing.Point(2, 0);
            this.LoginEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginEmailLabel.Name = "LoginEmailLabel";
            this.LoginEmailLabel.Size = new System.Drawing.Size(266, 28);
            this.LoginEmailLabel.TabIndex = 0;
            this.LoginEmailLabel.Text = "Email";
            this.LoginEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginPassLabel
            // 
            this.LoginPassLabel.AutoSize = true;
            this.LoginPassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPassLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginPassLabel.Location = new System.Drawing.Point(2, 60);
            this.LoginPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPassLabel.Name = "LoginPassLabel";
            this.LoginPassLabel.Size = new System.Drawing.Size(266, 28);
            this.LoginPassLabel.TabIndex = 1;
            this.LoginPassLabel.Text = "Κωδικός";
            this.LoginPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginConnectLabel
            // 
            this.loginConnectLabel.AutoSize = true;
            this.loginConnectLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginConnectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginConnectLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginConnectLabel.ForeColor = System.Drawing.Color.White;
            this.loginConnectLabel.Location = new System.Drawing.Point(2, 153);
            this.loginConnectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginConnectLabel.Name = "loginConnectLabel";
            this.loginConnectLabel.Size = new System.Drawing.Size(266, 32);
            this.loginConnectLabel.TabIndex = 2;
            this.loginConnectLabel.Text = "Σύνδεση";
            this.loginConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginConnectLabel.Click += new System.EventHandler(this.loginConnectLabel_Click);
            // 
            // loginEmailTextbox
            // 
            this.loginEmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginEmailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginEmailTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.loginEmailTextbox.Location = new System.Drawing.Point(2, 30);
            this.loginEmailTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.loginEmailTextbox.Name = "loginEmailTextbox";
            this.loginEmailTextbox.Size = new System.Drawing.Size(266, 26);
            this.loginEmailTextbox.TabIndex = 3;
            this.loginEmailTextbox.Text = "Συμπλήρωσε email";
            this.loginEmailTextbox.Enter += new System.EventHandler(this.loginEmailTextbox_Enter);
            this.loginEmailTextbox.Leave += new System.EventHandler(this.loginEmailTextbox_Leave);
            // 
            // loginPassTextbox
            // 
            this.loginPassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPassTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginPassTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.loginPassTextbox.Location = new System.Drawing.Point(2, 90);
            this.loginPassTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.loginPassTextbox.Name = "loginPassTextbox";
            this.loginPassTextbox.Size = new System.Drawing.Size(266, 26);
            this.loginPassTextbox.TabIndex = 4;
            this.loginPassTextbox.Text = "Πληκτρολογήστε κωδικό";
            this.loginPassTextbox.Enter += new System.EventHandler(this.loginPassTextbox_Enter);
            this.loginPassTextbox.Leave += new System.EventHandler(this.loginPassTextbox_Leave);
            // 
            // loginForgotLabel
            // 
            this.loginForgotLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginForgotLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginForgotLabel.Location = new System.Drawing.Point(2, 189);
            this.loginForgotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginForgotLabel.Name = "loginForgotLabel";
            this.loginForgotLabel.Size = new System.Drawing.Size(141, 16);
            this.loginForgotLabel.TabIndex = 5;
            this.loginForgotLabel.Text = "Ξέχασα τον κωδικό μου";
            this.loginForgotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginForgotLabel.MouseEnter += new System.EventHandler(this.loginForgotLabel_MouseEnter);
            this.loginForgotLabel.MouseLeave += new System.EventHandler(this.loginForgotLabel_MouseLeave);
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.registerTableLayout);
            this.registerTab.Location = new System.Drawing.Point(4, 25);
            this.registerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(2);
            this.registerTab.Size = new System.Drawing.Size(274, 213);
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
            this.registerTableLayout.Location = new System.Drawing.Point(2, 2);
            this.registerTableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.registerTableLayout.Name = "registerTableLayout";
            this.registerTableLayout.RowCount = 7;
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.registerTableLayout.Size = new System.Drawing.Size(270, 209);
            this.registerTableLayout.TabIndex = 0;
            // 
            // rEmailLabel
            // 
            this.rEmailLabel.AutoSize = true;
            this.rEmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rEmailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rEmailLabel.Location = new System.Drawing.Point(2, 0);
            this.rEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rEmailLabel.Name = "rEmailLabel";
            this.rEmailLabel.Size = new System.Drawing.Size(266, 24);
            this.rEmailLabel.TabIndex = 0;
            this.rEmailLabel.Text = "Email";
            this.rEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rPassLabel
            // 
            this.rPassLabel.AutoSize = true;
            this.rPassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPassLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rPassLabel.Location = new System.Drawing.Point(2, 52);
            this.rPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPassLabel.Name = "rPassLabel";
            this.rPassLabel.Size = new System.Drawing.Size(266, 24);
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
            this.registerLabel.Location = new System.Drawing.Point(2, 177);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(266, 32);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Εγγραφή";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // rEmailTextbox
            // 
            this.rEmailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rEmailTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.rEmailTextbox.Location = new System.Drawing.Point(2, 26);
            this.rEmailTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.rEmailTextbox.Name = "rEmailTextbox";
            this.rEmailTextbox.Size = new System.Drawing.Size(266, 26);
            this.rEmailTextbox.TabIndex = 3;
            this.rEmailTextbox.Text = "Συμπληρώστε email";
            this.rEmailTextbox.Enter += new System.EventHandler(this.rEmailTextbox_Enter);
            this.rEmailTextbox.Leave += new System.EventHandler(this.rEmailTextbox_Leave);
            // 
            // rPassTextbox1
            // 
            this.rPassTextbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPassTextbox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rPassTextbox1.ForeColor = System.Drawing.Color.DarkGray;
            this.rPassTextbox1.Location = new System.Drawing.Point(2, 78);
            this.rPassTextbox1.Margin = new System.Windows.Forms.Padding(2);
            this.rPassTextbox1.Name = "rPassTextbox1";
            this.rPassTextbox1.Size = new System.Drawing.Size(266, 26);
            this.rPassTextbox1.TabIndex = 4;
            this.rPassTextbox1.Text = "Πληκτρολογήστε κωδικό";
            this.rPassTextbox1.TextChanged += new System.EventHandler(this.rPassTextbox1_TextChanged);
            this.rPassTextbox1.Enter += new System.EventHandler(this.rPassTextbox1_Enter);
            this.rPassTextbox1.Leave += new System.EventHandler(this.rPassTextbox1_Leave);
            // 
            // rPassTextbox2
            // 
            this.rPassTextbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPassTextbox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rPassTextbox2.ForeColor = System.Drawing.Color.DarkGray;
            this.rPassTextbox2.Location = new System.Drawing.Point(2, 106);
            this.rPassTextbox2.Margin = new System.Windows.Forms.Padding(2);
            this.rPassTextbox2.Name = "rPassTextbox2";
            this.rPassTextbox2.Size = new System.Drawing.Size(266, 26);
            this.rPassTextbox2.TabIndex = 5;
            this.rPassTextbox2.Text = "Επαναλάβετε τον κωδικό";
            this.rPassTextbox2.TextChanged += new System.EventHandler(this.rPassTextbox2_TextChanged);
            this.rPassTextbox2.Enter += new System.EventHandler(this.rPassTextbox2_Enter);
            this.rPassTextbox2.Leave += new System.EventHandler(this.rPassTextbox2_Leave);
            // 
            // rPasswordMessage
            // 
            this.rPasswordMessage.AutoSize = true;
            this.rPasswordMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPasswordMessage.ForeColor = System.Drawing.Color.Red;
            this.rPasswordMessage.Location = new System.Drawing.Point(2, 132);
            this.rPasswordMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPasswordMessage.Name = "rPasswordMessage";
            this.rPasswordMessage.Size = new System.Drawing.Size(266, 45);
            this.rPasswordMessage.TabIndex = 6;
            this.rPasswordMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPicBox
            // 
            this.logoPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicBox.Image = global::AdopseAddsTeam5.Properties.Resources.name_color;
            this.logoPicBox.Location = new System.Drawing.Point(2, 34);
            this.logoPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(284, 53);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 2;
            this.logoPicBox.TabStop = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 346);
            this.Controls.Add(this.mainTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(304, 385);
            this.MinimumSize = new System.Drawing.Size(304, 385);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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