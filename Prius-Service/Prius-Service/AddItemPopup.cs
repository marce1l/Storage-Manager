using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class AddItemPopup : Form
    {
        public string Nev { get; private set; }
        public string Cikkszam { get; private set; }
        public string Vonalkod { get; private set; }
        public string Marka { get; private set; }
        public int Darabszam { get; private set; }
        public int Ar { get; private set; }


        public AddItemPopup()
        {
            InitializeComponent();
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            Nev = nev_TextBox.Text;
            Cikkszam = cikkszam_TextBox.Text;
            Vonalkod = vonalkod_textBox.Text;
            Marka = marka_TextBox.Text;
            
            //lekezelni
            Ar = Convert.ToInt32(ar_textBox.Text);
            Darabszam = Convert.ToInt32(darabszam_TextBox.Text);
        }

    }
}
