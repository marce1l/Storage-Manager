using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class InOutItem : Form
    {
        List<Termek> termekek = new List<Termek>();
        private bool beKi;
        private BarcodeReader br;
        private int index;
        public InOutItem(List<Termek> termekek, bool beKi)
        {
            InitializeComponent();
            this.termekek = termekek;
            this.beKi = beKi;
            br = new BarcodeReader(termekek);
        }

        private void InOutItem_Load(object sender, EventArgs e)
        {
            tLabel1.Visible = true;
            tLabel1.BringToFront();
            //beKi_richTextBox.ForeColor = SystemColors.ControlText;
            //beKi_richTextBox.Font = new Font("Segoe UI", 12);
            beKi_richTextBox.Text = "Hány darabot szeretnél ebből a termékből ";

            if (beKi)
            {
                textColor(beKi_richTextBox, "bevinni?", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Bevitel";
            }
            else
            {
                textColor(beKi_richTextBox, "kivinni?", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Kivitel";
            }

            br.ShowDialog();
            index = br.megtalaltSorszam;
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
            dataGridView.Columns[6].HeaderText = "Ár";

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Rows[0].Height = 30;

            dataGridView.ClearSelection();
        }

        private void igen_button_Click(object sender, EventArgs e)
        {
            if (beKi)
            {
                termekek[index].Darabszam += Convert.ToInt32(BeKiDarabszam_numericUpAndDown.Value);
            }
            else
            {
                termekek[index].Darabszam -= Convert.ToInt32(BeKiDarabszam_numericUpAndDown.Value);
            }
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
