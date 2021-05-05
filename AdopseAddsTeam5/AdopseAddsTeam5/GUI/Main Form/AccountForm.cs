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
            if (loginPassTextbox.Text == "Πληκτρολογήστε κωδικό")
            {
                loginPassTextbox.Text = "";
                loginPassTextbox.UseSystemPasswordChar = true;
                loginPassTextbox.ForeColor = System.Drawing.Color.Black;
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
            if (rEmailTextbox.Text == "Συμπληρώστε email")
            {
                rEmailTextbox.Text = "";
                rEmailTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void rEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (rEmailTextbox.Text == "")
            {
                rEmailTextbox.Text = "Συμπληρώστε email";
                rEmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void rPassTextbox1_Enter(object sender, EventArgs e)
        {
            if(rPassTextbox1.Text == "Πληκτρολογήστε κωδικό")
            {
                rPassTextbox1.Text = "";
                rPassTextbox1.UseSystemPasswordChar = true;
                rPassTextbox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void rPassTextbox2_Enter(object sender, EventArgs e)
        {
            if (rPassTextbox2.Text == "Επαναλάβετε τον κωδικό")
            {
                rPassTextbox2.Text = "";
                rPassTextbox2.UseSystemPasswordChar = true;
                rPassTextbox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            if(rPassTextbox1.Text == "Πληκτρολογήστε κωδικό" || rPassTextbox2.Text == "Επαναλάβετε τον κωδικό"
                || rPassTextbox1.Text == "" || rPassTextbox2.Text == "" || rEmailTextbox.Text == "" 
                || rEmailTextbox.Text == "Συμπληρώστε email")
            {
                rPasswordMessage.Text = "*Συμπληρώστε όλα τα πεδία";
            }
            else if (rPassTextbox1.Text != rPassTextbox2.Text)
            {
                rPasswordMessage.Text = "*Οι κωδικοί δεν ταιριάζουν.";
            }
            else
            {
                DataAccess db = new DataAccess();
                db.NewUser(rEmailTextbox.Text, rPassTextbox1.Text);
                User user = new User { EmailAddress = rEmailTextbox.Text, Password = rPassTextbox1.Text };
                MainForm.login(user);
                this.Close();
            }
        }

        private void rPassTextbox1_TextChanged(object sender, EventArgs e)
        {
            rPasswordMessage.Text = "";
        }

        private void rPassTextbox2_TextChanged(object sender, EventArgs e)
        {
            rPasswordMessage.Text = "";
        }

        private void rPassTextbox1_Leave(object sender, EventArgs e)
        {
            if (rPassTextbox1.Text == "")
            {
                rPassTextbox1.Text = "Πληκτρολογήστε κωδικό";
                rPassTextbox1.UseSystemPasswordChar = false;
                rPassTextbox1.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void rPassTextbox2_Leave(object sender, EventArgs e)
        {
            if (rPassTextbox2.Text == "")
            {
                rPassTextbox2.Text = "Επαναλάβετε τον κωδικό";
                rPassTextbox2.UseSystemPasswordChar = false;
                rPassTextbox2.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void loginPassTextbox_Leave(object sender, EventArgs e)
        {
            if (loginPassTextbox.Text == "")
            {
                loginPassTextbox.Text = "Πληκτρολογήστε κωδικό";
                loginPassTextbox.UseSystemPasswordChar = false;
                loginPassTextbox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void loginConnectLabel_Click(object sender, EventArgs e)
        {
            if (loginPassTextbox.Text == "Πληκτρολογήστε κωδικό" 
                || loginPassTextbox.Text == "" || loginEmailTextbox.Text == ""
                || loginEmailTextbox.Text == "Συμπληρώστε email")
            {
                rPasswordMessage.Text = "*Συμπληρώστε όλα τα πεδία";
            }
            else
            {
                User user = new User();
                DataAccess db = new DataAccess();
                user = db.LogIn(loginEmailTextbox.Text, loginPassTextbox.Text);
                if (user.Password == loginPassTextbox.Text)
                {
                    MainForm.login(user);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Λάθος email ή κωδικός");
                }
            } 
        }
    }
}
