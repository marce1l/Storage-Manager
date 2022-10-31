using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class ListProducts : Form
    {
        //kereseshez
        private CurrencyManager currencyManager;

        private List<string> nevek = new List<string>();
        private string editHistory;
        public ListProducts()
        {
            InitializeComponent();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            DisplayFunctions.Instance.Kilistaz(Data.Instance.termekek, this.dataGridView);

            currencyManager = (CurrencyManager)BindingContext[dataGridView.DataSource];

            AutoCompleteTextBox();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            int termekekSzama = Data.Instance.termekek.Count;

            AddItemPopup adp = new AddItemPopup();
            adp.ShowDialog();
            
            if (termekekSzama != Data.Instance.termekek.Count)
            {
                DisplayFunctions.Instance.Kilistaz(Data.Instance.termekek, this.dataGridView);

                DisplayFunctions.Instance.KevesDarabErtesites();
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
                if (dataGridView.SelectedCells[0].ColumnIndex == 3)
                {
                    BarcodeReader br = new BarcodeReader(false);
                    br.ShowDialog();

                    editHistory = dataGridView.SelectedCells[0].Value.ToString();
                    dataGridView.SelectedCells[0].Value = br.barcode;

                    if (br.bezartVagyHiba)
                    {
                        dataGridView.SelectedCells[0].Value = editHistory;
                    }
                }
                else
                {
                    int row = dataGridView.SelectedCells[0].RowIndex;
                    int column = dataGridView.SelectedCells[0].ColumnIndex;
                    DataGridViewCell cell = dataGridView.Rows[row].Cells[column];
                    dataGridView.CurrentCell = cell;

                    if (dataGridView.SelectedCells[0].Value != null)
                    {
                        editHistory = dataGridView.SelectedCells[0].Value.ToString();
                    }
                    
                    dataGridView.ReadOnly = false;
                    dataGridView.BeginEdit(true);
                }
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

                DialogResult dr = MessageBox.Show("Biztosan törölni szeretné ezt a terméket? \nNév: '" + Data.Instance.termekek[index].Nev + "' Cikkszám: '" + Data.Instance.termekek[index].Cikkszam + "'", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Data.Instance.termekek.RemoveAt(index);
                    DisplayFunctions.Instance.Kilistaz(Data.Instance.termekek, this.dataGridView);

                    DisplayFunctions.Instance.KevesDarabErtesites();
                }
            }
        }

        private void DisableInvalidCellEditing()
        {
            if (dataGridView.SelectedCells[0].Value != null)
            {
                string editContent = dataGridView.SelectedCells[0].Value.ToString();
                int editContentNumber = -1;

                try
                {
                    editContentNumber = Convert.ToInt32(editContent);

                    if (editContentNumber < 0)
                    {
                        MessageBox.Show("Nem lehet negatív az adott cella!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView.SelectedCells[0].Value = editHistory;
                    }
                    else
                    {
                        DisplayFunctions.Instance.KevesDarabErtesites();
                    }
                }
                catch (FormatException)
                {
                    dataGridView.SelectedCells[0].Value = editHistory;
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.ReadOnly = true;
            dataGridView.EndEdit();

            DisableInvalidCellEditing();
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Nem számot vagy túl nagy számot adott meg!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridView.SelectedCells[0].Value = editHistory;
        }

        private List<string> NevekKinyerese(List<Termek> lista)
        {
            List<string> nevekKinyerese = new List<string>();

            foreach (var termek in lista)
            {
                if (!(nevekKinyerese.Contains(termek.Nev)))
                {
                    nevekKinyerese.Add(termek.Nev);
                }
            }

            return nevekKinyerese;
        }

        private void AutoCompleteTextBox()
        {
            nevek.AddRange(NevekKinyerese(Data.Instance.termekek));
            nevek = nevek.Distinct().ToList();
            nevek.Sort();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(nevek.ToArray());
            kereso_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            kereso_textBox.AutoCompleteCustomSource = autoComplete;

            kereso_textBox.Text = "";
        }

        private void kereso_textBox_TextChanged(object sender, EventArgs e)
        {
            //kereseshez
            currencyManager.SuspendBinding();

            //MessageBox.Show("lol");
            if (kereso_textBox.Text != string.Empty)
            {
                dataGridView.Rows.OfType<DataGridViewRow>().Where(r => !r.Cells[0].Value.ToString().Trim().ToUpper().Contains(kereso_textBox.Text.ToUpper().Trim())).ToList().ForEach(row => { if (!row.IsNewRow) row.Visible = false; });
            }
            else
            {
                dataGridView.Rows.OfType<DataGridViewRow>().ToList().ForEach(row => { if (!row.IsNewRow) row.Visible = true; });
            }

            currencyManager.ResumeBinding();
        }
    }
}
