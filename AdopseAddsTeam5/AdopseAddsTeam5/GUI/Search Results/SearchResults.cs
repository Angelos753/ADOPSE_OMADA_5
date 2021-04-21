using AdopseAddsTeam5.GUI.Main_Form;
using AdopseAddsTeam5.GUI.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5.GUI.Templates
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            //mainTableLayout.Parent = backgroundTableLayout;
        }

        private void logLabel_Click(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm();
            a.ShowDialog();
        }

        private void saveFilterLabel_Click(object sender, EventArgs e)
        {
            FilterSave f = new FilterSave();
            f.ShowDialog();
        }
    }
}
