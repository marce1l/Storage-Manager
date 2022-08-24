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
        //X or this.Close
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public string barcode { get; private set; }
        public int megtalaltSorszam { get; private set; }
        public bool bezartVagyHiba { get; private set; }
        private bool keres;
        private List<Termek> termekek;
        public BarcodeReader(List<Termek> termekek, bool keres)
        {
            this.keres = keres;
            this.termekek = termekek;
            InitializeComponent();
        }

        private void BarcodeReader_Load(object sender, EventArgs e)
        {
            bezartVagyHiba = false;
        }

        private void barcode_textBox_TextChanged(object sender, EventArgs e)
        {
            barcode = barcode_textBox.Text;
            
            if (keres)
            {
                if (!(barcode == ""))
                {
                    vonalkodHibaKezeles();
                }
            }
            else
            {
                this.Close();
            }
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
            }
            else if (sorszam == -2)
            {
                this.Close();
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bezartVagyHiba = true;
            }
            else
            {
                megtalaltSorszam = sorszam;
                this.Close();
            }

            barcode_textBox.Text = "";
        }
        
        private void BarcodeReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (ClosedByXButtonOrAltF4)
            {
                bezartVagyHiba = true;
            }
        }
        
        //X or this.Close()
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
                ClosedByXButtonOrAltF4 = true;
            base.WndProc(ref msg);
        }
        protected override void OnShown(EventArgs e)
        {
            ClosedByXButtonOrAltF4 = false;
        }
    }
}
