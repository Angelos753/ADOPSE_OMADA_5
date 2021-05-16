using AdopseAddsTeam5.GUI.Main_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5.GUI.Custom_Controls
{
    public partial class ControlMessage : UserControl
    {

        public ControlMessage(string fname, string lname, string phone, string email, string desc, int mid)
        {
            InitializeComponent();
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.desc = desc;
            this.mid = mid;
        }

        private void provoliLabel_Click(object sender, EventArgs e)
        {
            MessageForm m = new MessageForm();
            m.setFields(fname, lname, phone, email, desc);
            m.ShowDialog();
        }

        private void diagrafiLabel_Click(object sender, EventArgs e)
        {
            DataAccess.deleteMsg(mid);
            this.Dispose();
        }

        private void favoritePicbox_Click(object sender, EventArgs e)
        {

        }

        private string fname;
        private string lname;
        private string phone;
        private string email;
        private string desc;
        private int mid;
    }
}
