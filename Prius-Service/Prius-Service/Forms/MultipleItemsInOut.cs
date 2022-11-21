using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class MultipleItemsInOut : Form
    {
        private int index;
        private string barcode;
        private List<Item> inOutItems = new List<Item>();
        private int inOutItemsCount;
        Timer _typingTimer;
        public MultipleItemsInOut()
        {
            InitializeComponent();
        }

        private void MultipleItemsInOut_Load(object sender, EventArgs e)
        {
            InOutSetup();
        }

        private void MultipleItemsInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_typingTimer != null)
            {
                _typingTimer.Tick -= this.HandleTypingTimerTimeout;
            }

            inOutItems.Clear();
        }

        private void InOutSetup()
        {
            transparentLabel1.Visible = true;
            transparentLabel1.BringToFront();
            
            transparentLabel2.Visible = true;
            transparentLabel2.BringToFront();
            
            barcode_textBox.Focus();

            inOut_richTextBox.Text = "Eddig ";
            inOutConfirm_richTextBox.Text = "";

            if (Data.Instance.InOut)
            {
                DisplayFunctions.Instance.TextColor(inOut_richTextBox, "bevitt", Color.Green, new Font("Segoe UI", 16, FontStyle.Bold));
                DisplayFunctions.Instance.TextColor(inOutConfirm_richTextBox, "Be", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Ömlesztett Bevitel";
                sumPrice_label.Location = new Point(583, 478);
                sumPrice_label.Text = "Összes beszerzési ára:";
            }
            else
            {
                DisplayFunctions.Instance.TextColor(inOut_richTextBox, "kivitt", Color.Red, new Font("Segoe UI", 16, FontStyle.Bold));
                DisplayFunctions.Instance.TextColor(inOutConfirm_richTextBox, "Ki", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Ömlesztett Kivitel";
            }

            DisplayFunctions.Instance.TextColor(inOutConfirm_richTextBox, " szeretnéd vinni ezeket a termékeket?", Color.Black, new Font("Segoe UI", 12));
            DisplayFunctions.Instance.TextColor(inOut_richTextBox, " termékek", SystemColors.ControlText, new Font("Segoe UI", 16));
        }

        private void ListItems()
        {
            bool isUsed = IndexIsUsed(index);

            if (!isUsed)
            {
                inOutItems.Add(new Item(Data.Instance.items[index].Name, Data.Instance.items[index].ItemNumber, Data.Instance.items[index].Manufacturer, Data.Instance.items[index].Barcode, 1, Data.Instance.items[index].MinQuantity, Data.Instance.items[index].CostPrice, Data.Instance.items[index].SellPrice));
                
                inOutItemsCount++;
                sumQuantityData_label.Text = inOutItemsCount + " db";
            }

            if (inOutItems.Count == 1)
            {
                scanPrompt_label.Visible = false;
            }

            BindingList<Item> bindingList = new BindingList<Item>(inOutItems);
            var source = new BindingSource(bindingList, null);
            dataGridView.DataSource = source;

            dataGridView.Columns.RemoveAt(3);
            dataGridView.Columns.RemoveAt(4);
            
            dataGridView.Columns[0].HeaderText = "Név";
            dataGridView.Columns[1].HeaderText = "Cikkszám";
            dataGridView.Columns[2].HeaderText = "Márka";

            if (Data.Instance.InOut)
            {
                dataGridView.Columns.RemoveAt(5);
                dataGridView.Columns[3].HeaderText = "Bevitt Darabszám";
                dataGridView.Columns[4].HeaderText = "Beszerzési Ár";
            }
            else
            {
                dataGridView.Columns.RemoveAt(4);
                dataGridView.Columns[3].HeaderText = "Kivitt Darabszám";
                dataGridView.Columns[4].HeaderText = "Eladási Ár";
            }

            dataGridView.Columns[4].DefaultCellStyle.Format = "N0";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Rows[0].Height = 30;

            dataGridView.ClearSelection();

            SumCalculation();
        }

        private void Barcode_textBox_TextChanged(object sender, EventArgs e)
        {
            if (_typingTimer == null)
            {
                _typingTimer = new Timer();
                _typingTimer.Interval = 300;
                _typingTimer.Tick += new EventHandler(this.HandleTypingTimerTimeout);
            }

            _typingTimer.Stop();
            _typingTimer.Tag = (sender as TextBox).Text;
            _typingTimer.Start();
        }

        private void HandleTypingTimerTimeout(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;

            if (timer == null)
            {
                return;
            }

            barcode = barcode_textBox.Text;

            timer.Stop();

            if (!(barcode == ""))
            {
                if (BarcodeErrorHandling())
                {
                    ListItems();
                }
            }
        }

        private bool BarcodeErrorHandling()
        {
            int ItemIndex = BarcodeExists(barcode);

            if (ItemIndex == -2)
            {
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barcode_textBox.Text = "";
                return false;
            }

            index = ItemIndex;
            barcode_textBox.Text = "";
            return true;
        }

        private int BarcodeExists(string barcode)
        {
            barcode = barcode.TrimEnd('\r', '\n');

            if (Data.Instance.malfunctioningBarcodeReader)
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

            for (int i = 0; i < Data.Instance.items.Count; i++)
            {
                if (Data.Instance.items[i].Barcode.Equals(barcode))
                {
                    return i;
                }
            }

            return -2;
        }
        //Hozzáadja a darabszámot ha már be lett olvasva a termék
        private bool IndexIsUsed(int itemIndex)
        {
            if (inOutItems.Count == 0)
            {
                return false;
            }
            for (int i = 0; i < inOutItems.Count; i++)
            {
                if (inOutItems[i].Barcode == Data.Instance.items[itemIndex].Barcode)
                {
                    inOutItems[i].Quantity += 1;

                    inOutItemsCount++;
                    sumQuantityData_label.Text = inOutItemsCount + " db";
                    
                    return true;
                }
            }

            return false;
        }

        private void SumCalculation()
        {
            int osszeg = 0;

            foreach (Item item in inOutItems)
            {
                if (Data.Instance.InOut)
                {
                    osszeg += item.CostPrice * item.Quantity;
                }
                else
                {
                    osszeg += item.SellPrice * item.Quantity;
                }
            }

            string sumString = osszeg.ToString("N0");
            sumPriceData_label.Text = sumString + " Ft";
        }

        private void Igen_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.Instance.items.Count; i++)
            {
                foreach (Item item in inOutItems)
                {
                    if (item.Barcode == Data.Instance.items[i].Barcode)
                    {
                        if (Data.Instance.InOut)
                        {
                            Data.Instance.items[i].Quantity += item.Quantity;
                            Data.Instance.StoreToReport(Data.Instance.items[i], item.Quantity);
                        }
                        else
                        {
                            if (item.Quantity > Data.Instance.items[i].Quantity)
                            {
                                MessageBox.Show("Nem lehet a " + item.Name + " termékből " + item.Quantity + " db-ot kivinni, mert csak " + Data.Instance.items[i].Quantity + " db van belőle raktáron!\nEbből a termékből ezért csak " + Data.Instance.items[i].Quantity + " db-ot vitt ki a rendszer", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Data.Instance.StoreToReport(Data.Instance.items[i]);
                                Data.Instance.items[i].Quantity = 0;
                            }
                            else
                            {
                                Data.Instance.items[i].Quantity -= item.Quantity;
                                Data.Instance.StoreToReport(Data.Instance.items[i], item.Quantity);
                            }
                        }
                    }
                }
            }

            DisplayFunctions.Instance.FewItemCountNotification();
        }
    }
}
