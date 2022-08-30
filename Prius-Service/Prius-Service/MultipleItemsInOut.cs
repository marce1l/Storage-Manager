using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class MultipleItemsInOut : Form
    {
        List<Termek> termekek;
        private bool beKi;
        private int index = 1;
        public MultipleItemsInOut(List<Termek> termekek, bool beKi)
        {
            this.termekek = termekek;
            this.beKi = beKi;
            InitializeComponent();
        }


        private void MultipleItemsInOut_Load(object sender, EventArgs e)
        {
            tLabel1.Visible = true;
            tLabel1.BringToFront();

            beKi_richTextBox.Text = "Eddig ";

            if (beKi)
            {
                textColor(beKi_richTextBox, "bevitt", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Ömlesztett Bevitel";
            }
            else
            {
                textColor(beKi_richTextBox, "kivitt", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Ömlesztett Kivitel";
            }

            textColor(beKi_richTextBox, " termékek", SystemColors.ControlText, new Font("Segoe UI", 12));

            Kilistaz();
        }

        private void Kilistaz()
        {
            List<Termek> beKiVittTermek = new List<Termek>();
            beKiVittTermek.Add(termekek[index]);

            BindingList<Termek> bindingList = new BindingList<Termek>(beKiVittTermek);
            var source = new BindingSource(bindingList, null);
            dataGridView.DataSource = source;

            dataGridView.Columns[0].HeaderText = "Név";
            dataGridView.Columns[1].HeaderText = "Cikkszám";
            dataGridView.Columns[2].HeaderText = "Márka";
            dataGridView.Columns[3].HeaderText = "Vonalkód";
            dataGridView.Columns[4].HeaderText = "Darabszám";
            dataGridView.Columns[5].HeaderText = "Minimum Darabszám";
            dataGridView.Columns[6].HeaderText = "Beszerzési Ár";
            dataGridView.Columns[7].HeaderText = "Eladási Ár";

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Rows[0].Height = 30;

            dataGridView.ClearSelection();
        }

        private void textColor(RichTextBox rtbx, string text, Color color, Font font)
        {
            int start = rtbx.TextLength;
            rtbx.AppendText(text);
            int end = rtbx.TextLength;

            rtbx.Select(start, end - start);
            rtbx.SelectionColor = color;
            rtbx.SelectionFont = font;

            rtbx.Select(end, 0);
        }
    }
}
