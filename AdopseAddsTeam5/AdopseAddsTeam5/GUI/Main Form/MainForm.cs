﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdopseAddsTeam5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private double panel1WidthRatio, panel1HeightRatio, panel2WidthRatio, panel2HeightRatio; // Global variables for maintaining ratio.

        private void MainForm_Load(object sender, EventArgs e)
        {
            watermarkPicBox.Parent = mainPictureBox;
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            double p1w = this.sideMenuPanel.Size.Width;    // Grab the panels' dimensions
            double p1h = this.sideMenuPanel.Size.Height;   // as soon as the user begins to resize
            //double p2w = this.middle_panel.Size.Width;  // in order to store
            //double p2h = this.middle_panel.Size.Height; // the Panel to Form
            double fw = this.mainTableLayout.Size.Width;                // dimension ratios.
            double fh = this.Size.Height;
            panel1WidthRatio = p1w / fw;
            panel1HeightRatio = p1h / fh;
            //panel2WidthRatio = p2w / fw;
            //panel2HeightRatio = p2h / fh;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (panel1WidthRatio != 0)
            {
                double formWidth = this.mainTableLayout.Size.Width;         // As soon as a new size is set
                double formHeight = this.Size.Height;       // resize the panel using the earlier ratio.
                this.sideMenuPanel.Size = new Size((int)(formWidth * panel1WidthRatio), this.mainTableLayout.Size.Height-35);
                //this.middle_panel.Size = new Size((int)(formWidth * panel2WidthRatio), (int)(formHeight * panel2HeightRatio));
                //this.middle_panel.Location = new System.Drawing.Point(this.Size.Width / 4 - 9, this.Size.Height / 4 - 24); // Constants used to correctly calculate center.
            }
        }

        private void sideMenuLabel_Click(object sender, EventArgs e)
        {
            sideMenuPanel.Visible = !sideMenuPanel.Visible;
        }
        //System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(00)))), ((int)(((byte)(205)))));
        //System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(16)))), ((int)(((byte)(80)))));


    }
}