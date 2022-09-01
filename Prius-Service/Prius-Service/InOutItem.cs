﻿using System;
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
        List<Termek> termekek;
        private bool beKi;
        private int index;
        public InOutItem(List<Termek> termekek, bool beKi, int index)
        {
            InitializeComponent();
            this.termekek = termekek;
            this.beKi = beKi;
            this.index = index;
        }

        private void InOutItem_Load(object sender, EventArgs e)
        {
            tLabel1.Visible = true;
            tLabel1.BringToFront();

            beKi_richTextBox.Text = "Hány darabot szeretnél ebből a termékből ";

            if (beKi)
            {
                TextColor(beKi_richTextBox, "bevinni?", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Bevitel";
            }
            else
            {
                TextColor(beKi_richTextBox, "kivinni?", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Kivitel";
            }
            
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

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

        private void TextColor(RichTextBox rtbx, string text, Color color, Font font)
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
