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
        private bool meghiusult;
        public List<Termek> ujTermekek = new List<Termek>();

        public AddItemPopup()
        {
            InitializeComponent();
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            meghiusult = false;

            Mentes();

            if (!meghiusult)
            {
                nev_TextBox.Text = "";
                cikkszam_TextBox.Text = "";
                vonalkod_textBox.Text = "";
                ar_textBox.Text = "";
                marka_TextBox.Text = "";
                darabszam_TextBox.Text = "";
                minDarabszam_textBox.Text = "";
            }
        }

        private void Mentes()
        {
            int darabszam = 0;
            int ar = 0;
            int minDarabszam = 0;

            try
            {
                ar = Convert.ToInt32(ar_textBox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (ar_textBox.Text == "")
                {
                    ar = 0;
                }
                else
                {
                    MessageBox.Show("Az Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                darabszam = Convert.ToInt32(darabszam_TextBox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (darabszam_TextBox.Text == "")
                {
                    darabszam = 0;
                }
                else
                {
                    MessageBox.Show("A darabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                minDarabszam = Convert.ToInt32(minDarabszam_textBox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (minDarabszam_textBox.Text == "")
                {
                    minDarabszam = 0;
                }
                else
                {
                    MessageBox.Show("A minDarabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Termek t = new Termek(nev_TextBox.Text, cikkszam_TextBox.Text, vonalkod_textBox.Text, marka_TextBox.Text, darabszam, minDarabszam, ar);
            ujTermekek.Add(t);
        }

        private void befejezes_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VonalkodBeolvas_Button_Click(object sender, EventArgs e)
        {
            BarcodeReader br = new BarcodeReader();
            br.ShowDialog();
            vonalkod_textBox.Text = br.barcode;
        }
    }
}
