using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5.GUI.Main_Form
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void loginEmailTextbox_Enter(object sender, EventArgs e)
        {
            if (loginEmailTextbox.Text == "Συμπλήρωσε email")
            {
                loginEmailTextbox.Text = "";
                loginEmailTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void loginEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (loginEmailTextbox.Text == "")
            {
                loginEmailTextbox.Text = "Συμπλήρωσε email";
                loginEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void loginPassTextbox_Enter(object sender, EventArgs e)
        {
            if (loginPassTextbox.Text == "Συμπλήρωσε κωδικό")
            {
                loginPassTextbox.Text = "";
                loginPassTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void loginPassTextbox_Leave(object sender, EventArgs e)
        {
            if (loginPassTextbox.Text == "")
            {
                loginPassTextbox.Text = "Συμπλήρωσε κωδικό";
                loginPassTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void loginForgotLabel_MouseEnter(object sender, EventArgs e)
        {
            loginForgotLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        }

        private void loginForgotLabel_MouseLeave(object sender, EventArgs e)
        {
            loginForgotLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
        }

        private void rEmailTextbox_Enter(object sender, EventArgs e)
        {
            if (rEmailTextbox.Text == "Συμπλήρωσε email")
            {
                rEmailTextbox.Text = "";
                rEmailTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void rEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (rEmailTextbox.Text == "")
            {
                rEmailTextbox.Text = "Συμπλήρωσε email";
                rEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void rPassTextbox1_Enter(object sender, EventArgs e)
        {
            if (rPassTextbox1.Text == "Συμπλήρωσε κωδικό")
            {
                rPassTextbox1.Text = "";
                rPassTextbox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void rPassTextbox1_Leave(object sender, EventArgs e)
        {
            if (rPassTextbox1.Text == "")
            {
                rPassTextbox1.Text = "Συμπλήρωσε κωδικό";
                rPassTextbox1.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void rPassTextbox2_Enter(object sender, EventArgs e)
        {
            if (rPassTextbox2.Text == "Επιβεβαίωση κωδικού")
            {
                rPassTextbox2.Text = "";
                rPassTextbox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void rPassTextbox2_Leave(object sender, EventArgs e)
        {
            if (rPassTextbox2.Text == "")
            {
                rPassTextbox2.Text = "Επιβεβαίωση κωδικού";
                rPassTextbox2.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            if(rPassTextbox1.Text!=rPassTextbox2.Text)
            {
                rPasswordMessage.Text = "*Οι κωδικοί δεν ταιριάζουν.";
            }
        }
    }
}
