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
    public partial class miniAd : UserControl
    {
        public miniAd()
        {
            InitializeComponent();
        }

        public void setTitle(string s)
        {
            title.Text = s;
        }

        public void setArea(string s)
        {
            area.Text = s;
        }

        public void setDate(string s)
        {
            date.Text = s;
        }

        public void setRooms(string s)
        {
            bedrooms.Text = s;
        }

        public void setBaths(string s)
        {
            baths.Text = s;
        }

        public void setPrice(string s)
        {
            price.Text = s;
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }
    }
}
