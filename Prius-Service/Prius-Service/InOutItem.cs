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
        private BarcodeReader br = new BarcodeReader();
        private int index;
        public InOutItem(List<Termek> termekek, bool beKi)
        {
            InitializeComponent();
            this.termekek = termekek;
            this.beKi = beKi;
        }

        private void InOutItem_Load(object sender, EventArgs e)
        {
            if (beKi)
            {
                beKi_label.Text = "Hány darabot szeretnél ebből a termékből bevinni?";
            }
            else
            {
                beKi_label.Text = "Hány darabot szeretnél ebből a termékből kivinni?";
            }

            br.ShowDialog();
            Kilistaz();
        }

        private void Kilistaz()
        {
            List<Termek> beKiVittTermek = new List<Termek>();
            beKiVittTermek.Add(termekek[VonalkodIndex()]);

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

        private int VonalkodIndex()
        {
            index = vonalkodKereses(br.barcode);

            if (index == -1)
            {
                
            }
            else if (index == -2)
            {
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return index;
            }

            //ellenőrizni
            return index;
        }

        public int vonalkodKereses(string vonalkod)
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
    }
}
