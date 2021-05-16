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
    public partial class miniAd : UserControl
    {
        public miniAd()
        {
            InitializeComponent();
        }

        private int id;
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
        private List<string> imagestrings = new List<string>();
        private List<Image> images = new List<Image>();

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
            address.Text = s;
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

        public void setId(int s)
        {
            id = s;
        }

        public void imageList(int sid)
        {
            imagestrings = DataAccess.showAddImages(sid);
            for(int i=0; i<imagestrings.Count; i++)
            {
                images.Add(ForImages.stringToImage(imagestrings[i]));
            }
            picBox.Image = images[0];
        }

        public int getId()
        {
            return id;
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
