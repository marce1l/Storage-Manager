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
            dataGridView.Columns[6].HeaderText = "Beszerzési Ár";
            dataGridView.Columns[7].HeaderText = "Eladási Ár";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Rows[0].Height = 30;

            dataGridView.ClearSelection();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup adp = new AddItemPopup(termekek);
            adp.ShowDialog();
            int termekekSzama = termekek.Count;
            termekek.AddRange(adp.ujTermekek);
            
            if (termekekSzama != termekek.Count)
            {
                Kilistazas();

                Menu m = new Menu();
                m.KevesDarabErtesites();
            }
        }

        private void EditItem_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0 || dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("A termék módosításához először jelölje ki a termék módosítandó celláját", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int row = dataGridView.SelectedCells[0].RowIndex;
                int column = dataGridView.SelectedCells[0].ColumnIndex;
                DataGridViewCell cell = dataGridView.Rows[row].Cells[column];
                dataGridView.CurrentCell = cell;
                dataGridView.ReadOnly = false;
                dataGridView.BeginEdit(true);
            }
        }

        private void DeleteItem_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 && dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("A termék törléséhez először jelölje ki a terméket", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index;
                if (dataGridView.SelectedRows.Count == 0)
                {
                    index = dataGridView.SelectedCells[0].RowIndex;
                }
                else
                {
                    index = dataGridView.SelectedRows[0].Index;
                }

                DialogResult dr = MessageBox.Show("Biztosan törölni szeretné ezt a terméket? \nNév: '" + termekek[index].Nev + "' Cikkszám: '" + termekek[index].Cikkszam + "'", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    termekek.RemoveAt(index);
                    Kilistazas();
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.ReadOnly = true;
            dataGridView.EndEdit();
        }
    }
}
