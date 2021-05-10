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
    public partial class ControlAd : UserControl
    {
        public ControlAd()
        {
            InitializeComponent();
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            string s = (this.Name).Substring(2, (this.Name).Length - 2);
            int id = Int32.Parse(s);
            DataAccess.deleteAdd(id);
            this.Dispose();
        }
    }
}
