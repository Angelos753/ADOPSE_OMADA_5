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
    public partial class ControlAd : UserControl
    {
        public ControlAd()
        {
            InitializeComponent();
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            string s = "ad41";
            string sub = s.Substring(2, 2);
            this.setInfo(sub);
            //this.Dispose();
        }
    }
}
