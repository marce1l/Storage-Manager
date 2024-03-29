﻿using System;
using System.Windows.Forms;
using Prius_Service.Data;

namespace Prius_Service
{
    public partial class BarcodeReader : Form
    {
        //X or this.Close
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public string barcode { get; private set; }
        public int FoundItemIndex { get; private set; }
        public bool closedOrError { get; private set; }
        private bool isSearchedFor;
        System.Windows.Forms.Timer _typingTimer;
        public BarcodeReader(bool isSearchedFor)
        {
            this.isSearchedFor = isSearchedFor;
            InitializeComponent();
        }

        private void BarcodeReader_Load(object sender, EventArgs e)
        {
            closedOrError = false;
        }

        private void BarcodeReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_typingTimer != null)
            {
                _typingTimer.Tick -= this.handleTypingTimerTimeout;
            }

            if (ClosedByXButtonOrAltF4)
            {
                closedOrError = true;
            }
        }

        private void barcode_textBox_TextChanged(object sender, EventArgs e)
        {
            if (_typingTimer == null)
            {
                _typingTimer = new Timer();
                _typingTimer.Interval = 300;
                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }

            _typingTimer.Stop();
            _typingTimer.Tag = (sender as TextBox).Text;
            _typingTimer.Start();
        }

        private void handleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer;

            if (timer == null)
            {
                return;
            }

            barcode = barcode_textBox.Text;

            timer.Stop();

            if (isSearchedFor)
            {
                if (!(barcode == ""))
                {
                    BarcodeErrorHandling();
                }
            }
            else
            {
                this.Close();
            }
        }

        private int BarcodeExists(string barcode)
        {

            if (String.IsNullOrEmpty(barcode))
            {
                return -1;
            }
            else
            {
                barcode = barcode.TrimEnd('\r', '\n');

                if (Settings.Instance.MalfunctioningBarcodeReader)
                {
                    char[] characters = barcode.ToCharArray();
                    
                    for (int i = 0; i < characters.Length; i++)
                    {
                        if (characters[i].Equals('ö'))
                        {
                            characters[i] = '0';
                        }
                    }

                    barcode = new string(characters);
                }

                for (int i = 0; i < HandleData.Instance.items.Count; i++)
                {
                    if (HandleData.Instance.items[i].Barcode.Equals(barcode))
                    {
                        return i;
                    }
                }
            }

            return -2;
        }

        private void BarcodeErrorHandling()
        {
            int ItemIndex = BarcodeExists(barcode);

            if (ItemIndex == -1)
            {
                MessageBox.Show("Nem olvasott be vonalkódot!\nKérem olvasson be egy vonalkódot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ItemIndex == -2)
            {
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                closedOrError = true;
            }
            else
            {
                FoundItemIndex = ItemIndex;
                this.Close();
            }

            barcode_textBox.Text = "";
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

        private void BarcodeReader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode.ToString() == "\n")
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
