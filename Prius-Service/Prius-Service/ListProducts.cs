using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class ListProducts : Form
    {
        private List<Termek> termekek;
        public ListProducts(List<Termek> termekek)
        {
            this.termekek = termekek;
            InitializeComponent();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            if (termekek.Count == 0)
            {
                MessageBox.Show("szar");
            }
            /*
            Termek t = new Termek("Malkcsh kjgbaxcjg jkxgyc", "l8293v75", "dfhbvcb", "6547546241", 2, 0, 1500000000);
            Termek z = new Termek("bfxcbc", "j3734k2", "xcxcv", "45769579345", 6, 0, 23512);
            proba.Add(t);
            proba.Add(z);
            */
            Kilistazas();
            

        }

        private void Kilistazas()
        {
            BindingList<Termek> bindingList = new BindingList<Termek>(termekek);
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

            dataGridView.ClearSelection();
        }
    }
}
