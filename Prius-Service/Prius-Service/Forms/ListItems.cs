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
    public partial class ListItems : Form
    {
        //kereseshez
        private CurrencyManager currencyManager;

        private List<string> itemNames = new List<string>();
        private string editHistory;
        public ListItems()
        {
            InitializeComponent();
        }

        private void ListItems_Load(object sender, EventArgs e)
        {
            DisplayFunctions.Instance.ListItems(Data.Instance.items, this.dataGridView);
            AutoCompleteTextBox();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            using (AddItemPopup adp = new AddItemPopup())
            {
                adp.ShowDialog();

                if (adp.itemsChanged)
                {
                    DisplayFunctions.Instance.ListItems(Data.Instance.items, this.dataGridView);
                    DisplayFunctions.Instance.FewItemCountNotification();

                    AutoCompleteTextBox();
                }
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
                    using (BarcodeReader br = new BarcodeReader(false))
                    {
                        br.ShowDialog();

                        editHistory = dataGridView.SelectedCells[0].Value.ToString();
                        dataGridView.SelectedCells[0].Value = br.barcode;

                        if (br.closedOrError)
                        {
                            dataGridView.SelectedCells[0].Value = editHistory;
                        }
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

                DialogResult dr = MessageBox.Show("Biztosan törölni szeretné ezt a terméket? \nNév: '" + Data.Instance.items[index].Name + "' Cikkszám: '" + Data.Instance.items[index].ItemNumber + "'", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Data.Instance.items.RemoveAt(index);

                    if (Data.Instance.items.Count != 0)
                    {
                        DisplayFunctions.Instance.ListItems(Data.Instance.items, this.dataGridView);
                        AutoCompleteTextBox();
                    }
                    else
                    {
                        dataGridView.DataSource = null;
                    }

                    DisplayFunctions.Instance.FewItemCountNotification();
                }
            }
        }

        private void DisableInvalidCellEditing(int columnIndex)
        {
            if (dataGridView.SelectedCells[0].Value != null)
            {
                string editContent = dataGridView.SelectedCells[0].Value.ToString();

                // Ha olyan mező van szerkesztve amibe csak számot lehet tárolni
                if (columnIndex == 4 || columnIndex == 5 || columnIndex == 6 || columnIndex == 7)
                {
                    try
                    {
                        int editContentNumber = Convert.ToInt32(editContent);

                        if (editContentNumber < 0)
                        {
                            MessageBox.Show("Nem lehet negatív az adott cella!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dataGridView.SelectedCells[0].Value = editHistory;
                        }
                        else
                        {
                            DisplayFunctions.Instance.FewItemCountNotification();
                        }
                    }
                    catch (FormatException)
                    {
                        dataGridView.SelectedCells[0].Value = editHistory;
                    }
                }
                else
                {
                    if (editContent.Contains(';'))
                    {
                        MessageBox.Show("Ez a mező nem tartalmazhatja a ';' karaktert", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView.SelectedCells[0].Value = editHistory;
                    }
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.ReadOnly = true;
            dataGridView.EndEdit();

            DisableInvalidCellEditing(e.ColumnIndex);
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Nem számot vagy túl nagy számot adott meg!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridView.SelectedCells[0].Value = editHistory;
        }

        private List<string> ExtractNames(List<Item> list)
        {
            List<string> extractNames = new List<string>();

            foreach (var item in list)
            {
                if (!(extractNames.Contains(item.Name)))
                {
                    extractNames.Add(item.Name);
                }
            }

            return extractNames;
        }

        private void AutoCompleteTextBox()
        {
            currencyManager = (CurrencyManager)BindingContext[dataGridView.DataSource];

            itemNames.AddRange(ExtractNames(Data.Instance.items));
            itemNames = itemNames.Distinct().ToList();
            itemNames.Sort();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(itemNames.ToArray());
            search_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            search_textBox.AutoCompleteCustomSource = autoComplete;

            search_textBox.Text = "";
        }

        private void kereso_textBox_TextChanged(object sender, EventArgs e)
        {
            //kereseshez
            currencyManager.SuspendBinding();

            if (search_textBox.Text != string.Empty)
            {
                dataGridView.Rows.OfType<DataGridViewRow>().Where(r => !r.Cells[0].Value.ToString().Trim().ToUpper().Contains(search_textBox.Text.ToUpper().Trim())).ToList().ForEach(row => { if (!row.IsNewRow) row.Visible = false; });
            }
            else
            {
                dataGridView.Rows.OfType<DataGridViewRow>().ToList().ForEach(row => { if (!row.IsNewRow) row.Visible = true; });
            }

            currencyManager.ResumeBinding();
        }
    }
}
