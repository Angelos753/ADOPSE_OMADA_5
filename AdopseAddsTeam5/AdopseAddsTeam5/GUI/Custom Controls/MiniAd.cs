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

        private string typos_akinitou;
        private string emvado;
        private string perioxi;
        private string domatia;
        private string mpania;
        private string timi;
        private string thermansi;
        private string perigrafi;
        private string eidos;
        private string dieythinsi;

        public void setTitle(string s)
        {
            typos_akinitou = s;
            title.Text = s;
        }

        public string getTypoAk()
        {
            return typos_akinitou;
        }

        public void setEmvado(string s)
        {
            emvado = s;
            title.Text += " - " + s + "τ.μ.";
        }

        public string getEmvado()
        {
            return emvado;
        }

        public void setArea(string s)
        {
            perioxi = s;
            area.Text = s;
        }

        public string getPerioxi()
        {
            return perioxi;
        }

        public void setDate(string s)
        {
            date.Text = s;
        }

        public void setRooms(string s)
        {
            domatia = s;
            bedrooms.Text = s;
        }

        public string getDomatia()
        {
            return domatia;
        }

        public void setBaths(string s)
        {
            mpania = s;
            baths.Text = s;
        }

        public string getMpania()
        {
            return mpania;
        }

        public void setPrice(string s)
        {
            timi = s;
            price.Text = s;
        }

        public string getTimi()
        {
            return timi;
        }

        public void setThermansi(string s)
        {
            thermansi = s;
        }

        public string getThermansi()
        {
            return thermansi;
        }

        public void setEidos(string s)
        {
            eidos = s;
        }

        public string getEidos()
        {
            return eidos;
        }
        public void setDieythinsi(string s)
        {
            dieythinsi = s;
        }

        public string getDieythinsi()
        {
            return dieythinsi;
        }

        public void setPerigrafi(string s)
        {
            perigrafi = s;
        }

        public string getPerigrafi()
        {
            return perigrafi;
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
