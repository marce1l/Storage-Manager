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
        private int index;
        public InOutItem(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void InOutItem_Load(object sender, EventArgs e)
        {
            InOutSetup();

            List<Item> beKiVittTermek = new List<Item>();
            beKiVittTermek.Add(Data.Instance.items[index]);

            DisplayFunctions.Instance.ListItems(beKiVittTermek, this.dataGridView);
        }

        private void InOutSetup()
        {
            transparentLabel1.Visible = true;
            transparentLabel1.BringToFront();

            inOut_richTextBox.Text = "Hány darabot szeretnél ebből a termékből ";

            if (Data.Instance.InOut)
            {
                DisplayFunctions.Instance.TextColor(inOut_richTextBox, "bevinni?", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Bevitel";
            }
            else
            {
                DisplayFunctions.Instance.TextColor(inOut_richTextBox, "kivinni?", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Kivitel";
                confirm_label.Text = "Biztosan ki szeretnéd vinni?";
                confirm_label.Location = new Point(526, 36);
            }
        }

        private void Igen_button_Click(object sender, EventArgs e)
        {
            int inOutQuantity = Convert.ToInt32(inOutQuantity_numericUpAndDown.Value);

            if (Data.Instance.InOut)
            {
                Data.Instance.items[index].Quantity += inOutQuantity;
                Data.Instance.StoreToReport(Data.Instance.items[index], inOutQuantity);
            }
            else
            {
                if (Data.Instance.items[index].Quantity < inOutQuantity)
                {
                    MessageBox.Show("Nem lehet a " + Data.Instance.items[index].Name + " termékből " + inOutQuantity + " db-ot kivinni, mert csak " + Data.Instance.items[index].Quantity + " db van belőle raktáron!\nEbből a termékből ezért csak " + Data.Instance.items[index].Quantity + " db-ot vitt ki a rendszer", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Data.Instance.StoreToReport(Data.Instance.items[index]);
                    Data.Instance.items[index].Quantity = 0;
                }
                else
                {
                    Data.Instance.items[index].Quantity -= inOutQuantity;
                    Data.Instance.StoreToReport(Data.Instance.items[index], inOutQuantity);
                }
            }

            DisplayFunctions.Instance.FewItemCountNotification();
        }
    }
}
