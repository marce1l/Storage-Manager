using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class AddItemPopup : Form
    {
        private bool cancelled;
        private List<string> manufacturers = new List<string>();
        

        public AddItemPopup()
        {
            InitializeComponent();
        }

        private void AddItemPopup_Load(object sender, EventArgs e)
        {
            BindingListToMarkaComboBox(Data.Instance.items);
            AutoCompleteComboBox();
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            cancelled = false;

            Save();

            if (!cancelled)
            {
                name_TextBox.Text = "";
                itemNumber_TextBox.Text = "";
                barcode_textBox.Text = "";
                costPrice_textBox.Text = "";
                sellPrice_Textbox.Text = "";
                manufacturer_comboBox.Text = "";
                quantity_TextBox.Text = "";
                minQuantity_textBox.Text = "";

                BindingListToMarkaComboBox(Data.Instance.items);
                AutoCompleteComboBox();
            }

            name_TextBox.Focus();
        }

        private void Save()
        {
            int quantity = 0;
            int costPrice = 0;
            int sellPrice = 0;
            int minQuantity = 0;

            try
            {
                costPrice = Convert.ToInt32(Regex.Replace(costPrice_textBox.Text, @"\s+", ""));
            }
            catch (FormatException)
            {
                if (costPrice_textBox.Text.Equals(""))
                {
                    costPrice = 0;
                }
                else
                {
                    MessageBox.Show("A Beszerzési Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    costPrice_textBox.Text = "";
                    cancelled = true;
                }
            }

            try
            {
                sellPrice = Convert.ToInt32(Regex.Replace(sellPrice_Textbox.Text, @"\s+", ""));
            }
            catch (FormatException)
            {
                if (sellPrice_Textbox.Text.Equals(""))
                {
                    sellPrice = 0;
                }
                else
                {
                    MessageBox.Show("Az Eladási Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sellPrice_Textbox.Text = "";
                    cancelled = true;
                }
            }

            try
            {
                quantity = Convert.ToInt32(Regex.Replace(quantity_TextBox.Text, @"\s+", ""));
            }
            catch (FormatException)
            {
                if (quantity_TextBox.Text.Equals(""))
                {
                    quantity = 0;
                }
                else
                {
                    MessageBox.Show("A darabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantity_TextBox.Text = "";
                    cancelled = true;
                }
            }

            try
            {
                minQuantity = Convert.ToInt32(Regex.Replace(minQuantity_textBox.Text, @"\s+", ""));
            }
            catch (FormatException)
            {
                if (minQuantity_textBox.Text.Equals(""))
                {
                    minQuantity = 0;
                }
                else
                {
                    MessageBox.Show("A minDarabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minQuantity_textBox.Text = "";
                    cancelled = true;
                }
            }

            if (String.IsNullOrEmpty(name_TextBox.Text) || String.IsNullOrEmpty(itemNumber_TextBox.Text))
            {
                cancelled = true;
                MessageBox.Show("A csillagos mezőket kötelező kitölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool duplicated = false;
                int itemIndex = -1;

                for (int i = 0; i < Data.Instance.items.Count; i++)
                {
                    if (Data.Instance.items[i].Barcode == barcode_textBox.Text)
                    {
                        duplicated = true;
                        itemIndex = i;
                        break;
                    }
                }

                if (duplicated)
                {
                    Data.Instance.items[itemIndex].Quantity += quantity;

                    DisplayFunctions.Instance.FewItemCountNotification();
                }
                else if (!cancelled)
                {
                    Item i = new Item(name_TextBox.Text, itemNumber_TextBox.Text, manufacturer_comboBox.Text, barcode_textBox.Text, quantity, minQuantity, costPrice, sellPrice);
                    Data.Instance.items.Add(i);

                    DisplayFunctions.Instance.FewItemCountNotification();
                }
            }
        }

        private void befejezes_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VonalkodBeolvas_Button_Click(object sender, EventArgs e)
        {
            BarcodeReader br = new BarcodeReader(false);
            br.ShowDialog();

            barcode_textBox.Text = br.barcode.TrimEnd();
        }

        private void BindingListToMarkaComboBox(List<Item> listToBind)
        {
            manufacturers.AddRange(ExtractManufacturers(listToBind));
            manufacturers = manufacturers.Distinct().ToList();
            manufacturers.Sort();

            BindingList<string> bindingList = new BindingList<string>(manufacturers);
            var source = new BindingSource(bindingList, null);
            manufacturer_comboBox.DataSource = source;

            manufacturer_comboBox.Text = "";
        }

        private List<string> ExtractManufacturers(List<Item> list)
        {
            List<string> extractManufacturers = new List<string>();

            foreach (var item in list)
            {
                if (!(extractManufacturers.Contains(item.Manufacturer)))
                {
                    extractManufacturers.Add(item.Manufacturer);
                }
            }

            return extractManufacturers;
        }

        private void AutoCompleteComboBox()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(manufacturers.ToArray());
            manufacturer_comboBox.AutoCompleteCustomSource = autoComplete;
            manufacturer_comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            manufacturer_comboBox.Text = "";
        }
        
        //az ezres helyekhez spacet tesz
        private void FormatTextBoxNumber(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    int valueBefore = Int32.Parse(textBox.Text, System.Globalization.NumberStyles.AllowThousands);
                    textBox.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("hu-HU"), "{0:N0}", valueBefore);
                    textBox.Select(textBox.Text.Length, 0);
                }
                catch (FormatException)
                {

                }
            }
        }
        
        private void beszerzesiAr_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            FormatTextBoxNumber(costPrice_textBox);
        }

        private void eladasiAr_Textbox_KeyUp(object sender, KeyEventArgs e)
        {
            FormatTextBoxNumber(sellPrice_Textbox);
        }

        private void darabszam_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            FormatTextBoxNumber(quantity_TextBox);
        }

        private void minDarabszam_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            FormatTextBoxNumber(minQuantity_textBox);
        }
    }
}
