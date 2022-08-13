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
        public BarcodeReader()
        {
            InitializeComponent();
        }

        private void barcode_textBox_TextChanged(object sender, EventArgs e)
        {
            barcode = barcode_textBox.Text;
            this.Close();
        }
    }
}
