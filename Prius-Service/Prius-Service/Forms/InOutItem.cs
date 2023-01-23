using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Prius_Service.Data;

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
            beKiVittTermek.Add(HandleData.Instance.items[index]);

            DisplayFunctions.Instance.ListItems(beKiVittTermek, this.dataGridView);
        }

        private void InOutSetup()
        {
            transparentLabel1.Visible = true;
            transparentLabel1.BringToFront();

            inOut_richTextBox.Text = "Hány darabot szeretnél ebből a termékből ";

            if (HandleData.Instance.InOut)
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

            if (HandleData.Instance.InOut)
            {
                HandleData.Instance.items[index].Quantity += inOutQuantity;
                HandleData.Instance.StoreToReport(HandleData.Instance.items[index], inOutQuantity);
            }
            else
            {
                if (HandleData.Instance.items[index].Quantity < inOutQuantity)
                {
                    MessageBox.Show("Nem lehet a " + HandleData.Instance.items[index].Name + " termékből " + inOutQuantity + " db-ot kivinni, mert csak " + HandleData.Instance.items[index].Quantity + " db van belőle raktáron!\nEbből a termékből ezért csak " + HandleData.Instance.items[index].Quantity + " db-ot vitt ki a rendszer", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HandleData.Instance.StoreToReport(HandleData.Instance.items[index]);
                    HandleData.Instance.items[index].Quantity = 0;
                }
                else
                {
                    HandleData.Instance.items[index].Quantity -= inOutQuantity;
                    HandleData.Instance.StoreToReport(HandleData.Instance.items[index], inOutQuantity);
                }
            }

            DisplayFunctions.Instance.FewItemCountNotification();
        }
    }
}
