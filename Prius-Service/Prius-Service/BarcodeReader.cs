using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class BarcodeReader : Form
    {
        public string barcode { get; private set; }
        public int megtalaltSorszam { get; private set; }
        private List<Termek> termekek = new List<Termek>();
        public BarcodeReader(List<Termek> termekek)
        {
            this.termekek = termekek;
            InitializeComponent();
        }

        private void barcode_textBox_TextChanged(object sender, EventArgs e)
        {
            barcode = barcode_textBox.Text;
            vonalkodHibaKezeles();
        }

        private int vonalkodVan(string vonalkod)
        {
            if (String.IsNullOrEmpty(vonalkod))
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < termekek.Count; i++)
                {
                    if (termekek[i].Vonalkod == vonalkod)
                    {
                        return i;
                    }
                }
            }

            return -2;
        }

        private void vonalkodHibaKezeles()
        {
            int sorszam = vonalkodVan(barcode);

            if (sorszam == -1)
            {
                MessageBox.Show("Nem olvasott be vonalkódot!\nKérem olvasson be egy vonalkódot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barcode_textBox.Text = "";
            }
            else if (sorszam == -2)
            {
                this.Close();
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                megtalaltSorszam = sorszam;
                this.Close();
            }
        }
    }
}
