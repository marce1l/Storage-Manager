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
        public bool itemsChanged { get; set; } = false;
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

            costPrice = NumberFieldsErrorHandling(costPrice, costPrice_textBox, "A Beszerzési Ár mezőnek számot adjon meg!");
            sellPrice = NumberFieldsErrorHandling(sellPrice, sellPrice_Textbox, "Az Eladási Ár mezőnek számot adjon meg!");
            quantity = NumberFieldsErrorHandling(quantity, quantity_TextBox, "A darabszám mezőnek számot adjon meg!");
            minQuantity = NumberFieldsErrorHandling(minQuantity, minQuantity_textBox, "A minDarabszám mezőnek számot adjon meg!");

            if (String.IsNullOrEmpty(name_TextBox.Text) || String.IsNullOrEmpty(itemNumber_TextBox.Text))
            {
                cancelled = true;
                MessageBox.Show("A csillagos mezőket kötelező kitölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name_TextBox.Text.Contains(';') || itemNumber_TextBox.Text.Contains(';') || manufacturer_comboBox.Text.Contains(';') || barcode_textBox.Text.Contains(';'))
            {
                if (name_TextBox.Text.Contains(';'))
                {
                    name_TextBox.Text = "";
                }

                if (itemNumber_TextBox.Text.Contains(';'))
                {
                    itemNumber_TextBox.Text = "";
                }

                if (manufacturer_comboBox.Text.Contains(';'))
                {
                    manufacturer_comboBox.Text = "";
                }

                if (barcode_textBox.Text.Contains(';'))
                {
                    barcode_textBox.Text = "";
                }

                cancelled = true;
                MessageBox.Show("A mezők nem tartalmazhatják a ';' karaktert!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool duplicated = false;
                int itemIndex = -1;

                for (int i = 0; i < Data.Instance.items.Count; i++)
                {
                    if (Data.Instance.items[i].Barcode == barcode_textBox.Text && barcode_textBox.Text != "")
                    {
                        DialogResult dialogResult = MessageBox.Show(String.Format("Ilyen vonalkóddal már van termék eltárolva!" +
                            "\nNév: '{0}'   Cikkszám: '{1}'   Darabszám: '{2}'\nSzeretnéd hozzáadni a darabszámát a meglévő termékéhez?" +
                            "\n(A következő lenne a(z) {3} termék darabszáma: {4})", 
                            Data.Instance.items[i].Name, Data.Instance.items[i].ItemNumber, Data.Instance.items[i].Quantity, Data.Instance.items[i].Name, (Data.Instance.items[i].Quantity+quantity)), "Figyelem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        if (dialogResult == DialogResult.Yes)
                        {
                            duplicated = true;
                            itemIndex = i;
                        }
                        else
                        {
                            cancelled = true;
                        }

                        break;
                    }
                }

                if (duplicated)
                {
                    Data.Instance.items[itemIndex].Quantity += quantity;

                    DisplayFunctions.Instance.FewItemCountNotification();
                    itemsChanged = true;
                }
                else if (!cancelled)
                {
                    Item i = new Item(name_TextBox.Text, itemNumber_TextBox.Text, manufacturer_comboBox.Text, barcode_textBox.Text, quantity, minQuantity, costPrice, sellPrice);
                    Data.Instance.items.Add(i);

                    DisplayFunctions.Instance.FewItemCountNotification();
                    itemsChanged = true;
                }
            }
        }

        private int NumberFieldsErrorHandling(int number, TextBox numberTextbox, string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(Regex.Replace(numberTextbox.Text, @"\s+", ""));
            }
            catch (FormatException)
            {
                if (numberTextbox.Text.Equals(""))
                {
                    number = 0;
                }
                else
                {
                    MessageBox.Show(errorMessage, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numberTextbox.Text = "";
                    cancelled = true;
                }
            }

            return number;
        }

        private void befejezes_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VonalkodBeolvas_Button_Click(object sender, EventArgs e)
        {
            using (BarcodeReader br = new BarcodeReader(false))
            {
                br.ShowDialog();

                if (br.barcode != null)
                {
                    barcode_textBox.Text = br.barcode.TrimEnd();
                }
            }
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
                catch (OverflowException)
                {
                    MessageBox.Show("Túl nagy számot adott meg!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = "";
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
