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
        private List<Termek> termekek;
        public List<Termek> ujTermekek = new List<Termek>();

        public AddItemPopup(List<Termek> termekek)
        {
            this.termekek = termekek;
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
                beszerzesiAr_textBox.Text = "";
                eladasiAr_Textbox.Text = "";
                marka_TextBox.Text = "";
                darabszam_TextBox.Text = "";
                minDarabszam_textBox.Text = "";
            }
        }

        private void Mentes()
        {
            int darabszam = 0;
            int beszerzesiAr = 0;
            int eladasiAr = 0;
            int minDarabszam = 0;

            try
            {
                beszerzesiAr = Convert.ToInt32(beszerzesiAr_textBox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (beszerzesiAr_textBox.Text.Equals(""))
                {
                    beszerzesiAr = 0;
                }
                else
                {
                    MessageBox.Show("A Beszerzési Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    beszerzesiAr_textBox.Text = "";
                }
            }

            try
            {
                eladasiAr = Convert.ToInt32(eladasiAr_Textbox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (eladasiAr_Textbox.Text.Equals(""))
                {
                    eladasiAr = 0;
                }
                else
                {
                    MessageBox.Show("Az Eladási Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    eladasiAr_Textbox.Text = "";
                }
            }

            try
            {
                darabszam = Convert.ToInt32(darabszam_TextBox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (darabszam_TextBox.Text.Equals(""))
                {
                    darabszam = 0;
                }
                else
                {
                    MessageBox.Show("A darabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    darabszam_TextBox.Text = "";
                }
            }

            try
            {
                minDarabszam = Convert.ToInt32(minDarabszam_textBox.Text);
            }
            catch (FormatException)
            {
                meghiusult = true;
                if (minDarabszam_textBox.Text.Equals(""))
                {
                    minDarabszam = 0;
                }
                else
                {
                    MessageBox.Show("A minDarabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minDarabszam_textBox.Text = "";
                }
            }

            if (String.IsNullOrEmpty(nev_TextBox.Text) || String.IsNullOrEmpty(cikkszam_TextBox.Text))
            {
                meghiusult = true;
                MessageBox.Show("A csillagos mezőket kötelező kitölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Termek t = new Termek(nev_TextBox.Text, cikkszam_TextBox.Text, marka_TextBox.Text, vonalkod_textBox.Text, darabszam, minDarabszam, beszerzesiAr, eladasiAr);
                ujTermekek.Add(t);
            }
        }

        private void befejezes_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VonalkodBeolvas_Button_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            BarcodeReader br = new BarcodeReader(termekek, false, m.rosszVonalkodOlvaso);
            br.ShowDialog();

            vonalkod_textBox.Text = br.barcode;
        }
    }
}
